using MiTiendaPOS.Models;
using MiTiendaPOS.Services;

namespace MiTiendaPOS.Forms
{
    public partial class FrmProductos : Form
    {
        private readonly ProductoService _servicio = new();
        private int _idSeleccionado;
        private bool _cargando = true;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCategorias();
                _cargando = false;
                CargarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudieron cargar los productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCategorias()
        {
            var categorias = _servicio.ListarCategorias();

            cboCategoria.DisplayMember = nameof(Categoria.Nombre);
            cboCategoria.ValueMember = nameof(Categoria.Id);
            cboCategoria.DataSource = categorias;

            var filtro = new List<Categoria>
            {
                new() { Id = 0, Nombre = "(Todas)" }
            };
            filtro.AddRange(categorias);

            cboFiltroCategoria.DisplayMember = nameof(Categoria.Nombre);
            cboFiltroCategoria.ValueMember = nameof(Categoria.Id);
            cboFiltroCategoria.DataSource = filtro;
        }

        private void CargarProductos()
        {
            if (_cargando) return;

            int categoriaId = cboFiltroCategoria.SelectedValue is int id ? id : 0;
            dgvProductos.DataSource = _servicio.Listar(txtBuscar.Text, categoriaId)
                .Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    Categoria = p.Categoria?.Nombre ?? "",
                    Precio = p.PrecioUnitario,
                    p.Stock,
                    Estado = p.Activo ? "Activo" : "Inactivo"
                })
                .ToList();

            if (dgvProductos.Columns["Precio"] != null)
                dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
        }

        private void Limpiar()
        {
            _idSeleccionado = 0;
            txtNombre.Clear();
            nudPrecio.Value = 0;
            nudStock.Value = 0;
            chkActivo.Checked = true;
            if (cboCategoria.Items.Count > 0)
                cboCategoria.SelectedIndex = 0;
            lblModo.Text = "Producto nuevo";
            btnEliminar.Enabled = false;
            dgvProductos.ClearSelection();
            txtNombre.Focus();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Id"].Value);
            Producto? producto = _servicio.ObtenerPorId(id);
            if (producto == null) return;

            _idSeleccionado = producto.Id;
            txtNombre.Text = producto.Nombre;
            cboCategoria.SelectedValue = producto.CategoriaId;
            nudPrecio.Value = producto.PrecioUnitario;
            nudStock.Value = producto.Stock;
            chkActivo.Checked = producto.Activo;
            lblModo.Text = $"Editando producto #{producto.Id}";
            btnEliminar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedValue is not int categoriaId)
            {
                MessageBox.Show("Primero registre al menos una categoría.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var producto = new Producto
            {
                Id = _idSeleccionado,
                Nombre = txtNombre.Text,
                CategoriaId = categoriaId,
                PrecioUnitario = nudPrecio.Value,
                Stock = (int)nudStock.Value,
                Activo = chkActivo.Checked
            };

            try
            {
                bool esNuevo = _idSeleccionado == 0;
                _servicio.Guardar(producto);
                MessageBox.Show(esNuevo ? "Producto registrado." : "Producto actualizado.",
                    "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_idSeleccionado == 0) return;

            var respuesta = MessageBox.Show(
                $"¿Eliminar el producto #{_idSeleccionado}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta != DialogResult.Yes) return;

            try
            {
                string mensaje = _servicio.Eliminar(_idSeleccionado);
                MessageBox.Show(mensaje, "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo eliminar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e) => Limpiar();

        private void Filtros_Changed(object sender, EventArgs e) => CargarProductos();
    }
}