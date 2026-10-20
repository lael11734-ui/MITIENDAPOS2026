namespace MiTiendaPOS.Forms
{
    partial class FrmProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpDatos = new GroupBox();
            chkActivo = new CheckBox();
            nudStock = new NumericUpDown();
            nudPrecio = new NumericUpDown();
            cboCategoria = new ComboBox();
            txtNombre = new TextBox();
            lblStock = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            lblNombre = new Label();
            lblModo = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            lblFiltro = new Label();
            cboFiltroCategoria = new ComboBox();
            dgvProductos = new DataGridView();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(nudStock);
            grpDatos.Controls.Add(nudPrecio);
            grpDatos.Controls.Add(cboCategoria);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblStock);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(lblCategoria);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(lblModo);
            grpDatos.Location = new Point(20, 18);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(850, 145);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del producto";
            // 
            // lblModo
            // 
            lblModo.AutoSize = true;
            lblModo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModo.Location = new Point(18, 25);
            lblModo.Name = "lblModo";
            lblModo.Size = new Size(91, 15);
            lblModo.TabIndex = 0;
            lblModo.Text = "Producto nuevo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(18, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(57, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(18, 80);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategoria.Location = new Point(300, 58);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(67, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(300, 80);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(190, 23);
            cboCategoria.TabIndex = 4;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.Location = new Point(512, 58);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(47, 15);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = 0.05M;
            nudPrecio.Maximum = 10000;
            nudPrecio.Location = new Point(512, 80);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.Location = new Point(654, 58);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(43, 15);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock:";
            // 
            // nudStock
            // 
            nudStock.Maximum = 100000;
            nudStock.Location = new Point(654, 80);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(90, 23);
            nudStock.TabIndex = 8;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(765, 82);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(57, 19);
            chkActivo.TabIndex = 9;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // buttons
            // 
            btnNuevo = CrearBoton(btnNuevo, "Nuevo", 20, 178, btnNuevo_Click);
            btnGuardar = CrearBoton(btnGuardar, "Guardar", 115, 178, btnGuardar_Click);
            btnEliminar = CrearBoton(btnEliminar, "Eliminar", 210, 178, btnEliminar_Click);
            btnEliminar.Enabled = false;
            // 
            // filters
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.Location = new Point(20, 230);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(51, 15);
            lblBuscar.TabIndex = 10;
            lblBuscar.Text = "Buscar:";
            txtBuscar.Location = new Point(77, 227);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(260, 23);
            txtBuscar.TabIndex = 11;
            txtBuscar.TextChanged += Filtros_Changed;
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltro.Location = new Point(365, 230);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(67, 15);
            lblFiltro.TabIndex = 12;
            lblFiltro.Text = "Categoría:";
            cboFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFiltroCategoria.FormattingEnabled = true;
            cboFiltroCategoria.Location = new Point(438, 227);
            cboFiltroCategoria.Name = "cboFiltroCategoria";
            cboFiltroCategoria.Size = new Size(220, 23);
            cboFiltroCategoria.TabIndex = 13;
            cboFiltroCategoria.SelectedIndexChanged += Filtros_Changed;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(20, 270);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(850, 260);
            dgvProductos.TabIndex = 14;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 555);
            Controls.Add(dgvProductos);
            Controls.Add(cboFiltroCategoria);
            Controls.Add(lblFiltro);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mantenimiento de Productos";
            Load += FrmProductos_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private static Button CrearBoton(Button boton, string texto, int x, int y,
            EventHandler evento)
        {
            boton.Location = new Point(x, y);
            boton.Name = "btn" + texto;
            boton.Size = new Size(85, 32);
            boton.TabIndex = 15;
            boton.Text = texto;
            boton.UseVisualStyleBackColor = true;
            boton.Click += evento;
            return boton;
        }

        #endregion

        private GroupBox grpDatos;
        private CheckBox chkActivo;
        private NumericUpDown nudStock;
        private NumericUpDown nudPrecio;
        private ComboBox cboCategoria;
        private TextBox txtNombre;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblCategoria;
        private Label lblNombre;
        private Label lblModo;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Label lblFiltro;
        private ComboBox cboFiltroCategoria;
        private DataGridView dgvProductos;
    }
}