using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Models;

namespace MiTiendaPOS.Services
{
    public class ProductoService
    {
        public List<Categoria> ListarCategorias()
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Categorias.AsNoTracking()
                .OrderBy(c => c.Nombre)
                .ToList();
        }

        public List<Producto> Listar(string texto = "", int categoriaId = 0)
        {
            using var ctx = new MiTiendaPOSContext();
            IQueryable<Producto> consulta = ctx.Productos
                .AsNoTracking()
                .Include(p => p.Categoria);

            if (!string.IsNullOrWhiteSpace(texto))
                consulta = consulta.Where(p => p.Nombre.Contains(texto.Trim()));

            if (categoriaId > 0)
                consulta = consulta.Where(p => p.CategoriaId == categoriaId);

            return consulta.OrderBy(p => p.Nombre).ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            return ctx.Productos.AsNoTracking()
                .FirstOrDefault(p => p.Id == id);
        }

        public void Guardar(Producto producto)
        {
            producto.Nombre = producto.Nombre?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new InvalidOperationException("El nombre es obligatorio.");
            if (producto.PrecioUnitario <= 0)
                throw new InvalidOperationException("El precio debe ser mayor que cero.");
            if (producto.Stock < 0)
                throw new InvalidOperationException("El stock no puede ser negativo.");

            using var ctx = new MiTiendaPOSContext();

            if (!ctx.Categorias.Any(c => c.Id == producto.CategoriaId))
                throw new InvalidOperationException("La categoría no existe.");

            bool duplicado = ctx.Productos.Any(p =>
                p.Nombre == producto.Nombre && p.Id != producto.Id);
            if (duplicado)
                throw new InvalidOperationException(
                    $"Ya existe un producto '{producto.Nombre}'.");

            if (producto.Id == 0)
                ctx.Productos.Add(producto);
            else
                ctx.Productos.Update(producto);

            ctx.SaveChanges();
        }

        public string Eliminar(int id)
        {
            using var ctx = new MiTiendaPOSContext();
            Producto producto = ctx.Productos.Find(id)
                ?? throw new InvalidOperationException("El producto ya no existe.");

            if (ctx.DetallesVenta.Any(d => d.ProductoId == id))
            {
                producto.Activo = false;
                ctx.SaveChanges();
                return "El producto tiene ventas registradas, por lo que se desactivó.";
            }

            ctx.Productos.Remove(producto);
            ctx.SaveChanges();
            return "Producto eliminado.";
        }
    }
}