using Microsoft.EntityFrameworkCore;
using MiTiendaPOS.Data;
using MiTiendaPOS.Forms;
using System.Globalization;

namespace MiTiendaPOS
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //método generico para abrir cualquier formulario como ventana modal
        private void AbrirFormulario<T>() where T : Form, new()
        {
            try
            {
                using var form = new T();
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO se pudo abrir el formulario", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var region = new CultureInfo("es-SV");
            lblFecha.Text = DateTime.Now.ToString("dddd, " +
                "dd 'de' MMMM 'de' yyyy", region);
            lblEstado.Text = "Listo!";
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias form = new FrmCategorias();
            form.ShowDialog();
            //form.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e) => AbrirFormulario<FrmVentas>();
    }
}
