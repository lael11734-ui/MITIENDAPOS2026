namespace MiTiendaPOS.Forms
{
    partial class FrmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpEncabezado = new GroupBox();
            cboUsuario = new ComboBox();
            cboCliente = new ComboBox();
            lblVenta = new Label();
            lblUsuario = new Label();
            lblCliente = new Label();
            grpHiistorial = new GroupBox();
            dgvVentas = new DataGridView();
            grpDetalle = new GroupBox();
            btnQuitar = new Button();
            dgvDetalle = new DataGridView();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            cboProducto = new ComboBox();
            lblTotal = new Label();
            lblCantidad = new Label();
            lblProducto = new Label();
            btnNueva = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            grpEncabezado.SuspendLayout();
            grpHiistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // grpEncabezado
            // 
            grpEncabezado.Controls.Add(cboUsuario);
            grpEncabezado.Controls.Add(cboCliente);
            grpEncabezado.Controls.Add(lblVenta);
            grpEncabezado.Controls.Add(lblUsuario);
            grpEncabezado.Controls.Add(lblCliente);
            grpEncabezado.Location = new Point(12, 12);
            grpEncabezado.Name = "grpEncabezado";
            grpEncabezado.Size = new Size(575, 100);
            grpEncabezado.TabIndex = 0;
            grpEncabezado.TabStop = false;
            grpEncabezado.Text = "Encabezado de la Venta";
            // 
            // cboUsuario
            // 
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Location = new Point(397, 33);
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(148, 23);
            cboUsuario.TabIndex = 6;
            // 
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(70, 33);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(236, 23);
            cboCliente.TabIndex = 5;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(17, 70);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(73, 15);
            lblVenta.TabIndex = 4;
            lblVenta.Text = "Nueva Venta";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(341, 36);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(17, 36);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // grpHiistorial
            // 
            grpHiistorial.Controls.Add(dgvVentas);
            grpHiistorial.Location = new Point(610, 12);
            grpHiistorial.Name = "grpHiistorial";
            grpHiistorial.Size = new Size(382, 537);
            grpHiistorial.TabIndex = 1;
            grpHiistorial.TabStop = false;
            grpHiistorial.Text = "Historial de Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(20, 22);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(346, 481);
            dgvVentas.TabIndex = 12;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // grpDetalle
            // 
            grpDetalle.Controls.Add(btnQuitar);
            grpDetalle.Controls.Add(dgvDetalle);
            grpDetalle.Controls.Add(btnAgregar);
            grpDetalle.Controls.Add(nudCantidad);
            grpDetalle.Controls.Add(cboProducto);
            grpDetalle.Controls.Add(lblTotal);
            grpDetalle.Controls.Add(lblCantidad);
            grpDetalle.Controls.Add(lblProducto);
            grpDetalle.Location = new Point(12, 133);
            grpDetalle.Name = "grpDetalle";
            grpDetalle.Size = new Size(575, 349);
            grpDetalle.TabIndex = 1;
            grpDetalle.TabStop = false;
            grpDetalle.Text = "Detalle de Productos";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(30, 296);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(102, 23);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "Quitar Linea";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(30, 86);
            dgvDetalle.MultiSelect = false;
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersVisible = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(515, 188);
            dgvDetalle.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(443, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(359, 34);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(64, 23);
            nudCantidad.TabIndex = 9;
            // 
            // cboProducto
            // 
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(82, 34);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(215, 23);
            cboProducto.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(341, 300);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(318, 37);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(35, 15);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cant:";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(17, 37);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(59, 15);
            lblProducto.TabIndex = 5;
            lblProducto.Text = "Producto:";
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(42, 510);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(102, 23);
            btnNueva.TabIndex = 13;
            btnNueva.Text = "Nueva Venta";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(216, 510);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 23);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar Venta";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(409, 510);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar Venta";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 561);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNueva);
            Controls.Add(grpDetalle);
            Controls.Add(grpHiistorial);
            Controls.Add(grpEncabezado);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmVentas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registro de Ventas";
            Load += FrmVentas_Load;
            grpEncabezado.ResumeLayout(false);
            grpEncabezado.PerformLayout();
            grpHiistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpDetalle.ResumeLayout(false);
            grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpEncabezado;
        private GroupBox grpHiistorial;
        private GroupBox grpDetalle;
        private ComboBox cboCliente;
        private Label lblVenta;
        private Label lblUsuario;
        private Label lblCliente;
        private ComboBox cboUsuario;
        private ComboBox cboProducto;
        private Label lblTotal;
        private Label lblCantidad;
        private Label lblProducto;
        private DataGridView dgvDetalle;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private DataGridView dgvVentas;
        private Button btnQuitar;
        private Button btnNueva;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}