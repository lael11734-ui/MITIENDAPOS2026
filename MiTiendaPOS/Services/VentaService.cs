using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Dtos;
using MiTiendaPOS.Models;


namespace MiTiendaPOS.Services
{
    public  class VentaService
    {
        // ----- Catálogos para los ComboBox (tablas de las que depende) -----
        public List<Cliente> ListarClientes()
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Clientes.AsNoTracking().OrderBy(c => c.Nombre).ToList();
        }

        public List<Usuario> ListarUsuarios()
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Usuarios.AsNoTracking().OrderBy(u => u.NombreUsuario).ToList();
        }

        public List<Producto> ListarProductosActivos()
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Productos.AsNoTracking()
                      .Where(p => p.Activo)
                      .OrderBy(p => p.Nombre)
                      .ToList();
        }

        // ----- READ: historial (maestro + cliente) -----
        public List<Venta> ListarVentas()
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Ventas.AsNoTracking()
                      .Include(v => v.Cliente)          // JOIN con Clientes
                      .OrderByDescending(v => v.Fecha)
                      .ToList();
        }

        // ----- READ: una venta con sus líneas(detalles) y el producto de cada línea -----
        public Venta? ObtenerConDetalle(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Ventas.AsNoTracking()
                      .Include(v => v.Detalles)         // JOIN con DetallesVenta
                          .ThenInclude(d => d.Producto) // JOIN con Productos
                      .FirstOrDefault(v => v.Id == id);
        }

        // (Paso 2: aquí agregaremos los métodos de escritura)
        // ----- CREATE: encabezado de la venta + detalles + stock en un solo evento SaveChanges -----
        public int Registrar(int clienteId, int usuarioId,
                             IEnumerable<LineaVenta> lineas)
        {
            var lista = lineas.ToList();
            if (lista.Count == 0)
                throw new InvalidOperationException("La venta no tiene productos.");

            using var ctx = new MiTiendaPOSContext();
            var venta = new Venta
            {
                Fecha = DateTime.Now,
                ClienteId = clienteId,     // FK hacia tabla Cliente
                UsuarioId = usuarioId      // FK hacia tabla Usuario
            };

            venta.Detalles.AddRange(CrearDetalles(ctx, lista));
            venta.Total = venta.Detalles.Sum(d => d.Subtotal);

            ctx.Ventas.Add(venta);   // Added: la venta Y sus detalles
            ctx.SaveChanges();       // INSERT en Ventas y en Detalles, UPDATE en Productos
            return venta.Id;         // EF asigna el Id generado por SQL Server
        }

        // ----- UPDATE: devolver stock, reemplazar líneas, descontar de nuevo -----
        public void Actualizar(int ventaId, int clienteId, int usuarioId,
                               IEnumerable<LineaVenta> lineas)
        {
            var lista = lineas.ToList();
            if (lista.Count == 0)
                throw new InvalidOperationException("La venta no tiene productos.");

            using var ctx = new MiTiendaPOSContext();
            Venta venta = ctx.Ventas.Include(v => v.Detalles)
                                    .FirstOrDefault(v => v.Id == ventaId)
                ?? throw new InvalidOperationException("La venta ya no existe.");

            // 1) Devolver al inventario lo vendido y borrar las líneas viejas
            var anteriores = venta.Detalles.ToList();
            foreach (var d in anteriores)
            {
                Producto producto = ctx.Productos.Find(d.ProductoId)!;
                producto.Stock += d.Cantidad;
            }
            ctx.DetallesVenta.RemoveRange(anteriores);

            // 2) Crear las líneas nuevas (valida y descuenta stock otra vez)
            var nuevos = CrearDetalles(ctx, lista);
            foreach (var d in nuevos) d.VentaId = venta.Id;
            ctx.DetallesVenta.AddRange(nuevos);

            // 3) Actualizar el encabezado
            venta.ClienteId = clienteId;
            venta.UsuarioId = usuarioId;
            venta.Total = nuevos.Sum(d => d.Subtotal);

            ctx.SaveChanges();   // DELETE/INSERT en Detalles, UPDATE en Ventas y Productos
        }

        // ----- DELETE: devolver stock y borrar (OJO:Cascade borra los detalles) -----
        public void Eliminar(int ventaId)
        {
            /*
            using var ctx = new MiTiendaPOSContext();
            Venta venta = ctx.Ventas.Include(v => v.Detalles)
                                    .FirstOrDefault(v => v.Id == ventaId)
                ?? throw new InvalidOperationException("La venta ya no existe.");

            foreach (var d in venta.Detalles)
            {
                Producto? producto = ctx.Productos.Find(d.ProductoId);
                if (producto != null) producto.Stock += d.Cantidad;
            }

            ctx.Ventas.Remove(venta);   // Cascade -> también sus DetalleVenta
            ctx.SaveChanges();
            */
            using var ctx = new MiTiendaPOSContext();
            Venta venta = ctx.Ventas.Include(v => v.Detalles)
                .FirstOrDefault(v => v.Id == ventaId)
                ?? throw new InvalidOperationException("La venta ya no existe.");

            foreach (var d in venta.Detalles)
            {
                Producto? producto = ctx.Productos.Find(d.ProductoId);
                if (producto != null) producto.Stock += d.Cantidad;
            }

            ctx.DetallesVenta.RemoveRange(venta.Detalles); // 1) primero los hijos
            ctx.Ventas.Remove(venta);                      // 2) luego el maestro
            ctx.SaveChanges();                             // EF ordena los DELETE correctamente
        }

        // ----- Lógica compartida: validamos stock, lo descontamos y armamos las líneas -----
        private static List<DetalleVenta> CrearDetalles(MiTiendaPOSContext ctx,
                                                        List<LineaVenta> lineas)
        {
            var detalles = new List<DetalleVenta>();
            foreach (var linea in lineas)
            {
                Producto producto = ctx.Productos.Find(linea.ProductoId)
                    ?? throw new InvalidOperationException("Producto no encontrado.");

                if (producto.Stock < linea.Cantidad)
                    throw new InvalidOperationException(
                        $"Stock insuficiente de '{producto.Nombre}'. " +
                        $"Disponible: {producto.Stock}.");

                producto.Stock -= linea.Cantidad;   // Modified -> UPDATE en Productos

                detalles.Add(new DetalleVenta
                {
                    ProductoId = producto.Id,
                    Cantidad = linea.Cantidad,
                    PrecioUnitario = producto.PrecioUnitario,   // precio de la BD
                    Subtotal = linea.Cantidad * producto.PrecioUnitario
                });
            }
            return detalles;
        }


    }
}
