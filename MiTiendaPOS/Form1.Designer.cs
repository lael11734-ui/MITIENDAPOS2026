namespace MiTiendaPOS
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuPrincipal = new MenuStrip();
            mnuSalir = new ToolStripMenuItem();
            mnuCatalogos = new ToolStripMenuItem();
            mnuCategorias = new ToolStripMenuItem();
            mnuProductos = new ToolStripMenuItem();
            mnuClientes = new ToolStripMenuItem();
            mnuOperaciones = new ToolStripMenuItem();
            mnuVentas = new ToolStripMenuItem();
            stsEstado = new StatusStrip();
            pnlMenuLateral = new Panel();
            btnVentas = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnCategorias = new Button();
            label2 = new Label();
            label1 = new Label();
            picLogo = new PictureBox();
            lblEstado = new ToolStripStatusLabel();
            lblFecha = new ToolStripStatusLabel();
            mnuPrincipal.SuspendLayout();
            stsEstado.SuspendLayout();
            pnlMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuSalir, mnuCatalogos, mnuOperaciones });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(1184, 24);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(41, 20);
            mnuSalir.Text = "&Salir";
            // 
            // mnuCatalogos
            // 
            mnuCatalogos.DropDownItems.AddRange(new ToolStripItem[] { mnuCategorias, mnuProductos, mnuClientes });
            mnuCatalogos.Name = "mnuCatalogos";
            mnuCatalogos.Size = new Size(72, 20);
            mnuCatalogos.Text = "Catálogos";
            // 
            // mnuCategorias
            // 
            mnuCategorias.Name = "mnuCategorias";
            mnuCategorias.Size = new Size(130, 22);
            mnuCategorias.Text = "Categorias";
            // 
            // mnuProductos
            // 
            mnuProductos.Name = "mnuProductos";
            mnuProductos.Size = new Size(130, 22);
            mnuProductos.Text = "Productos";
            mnuProductos.Click += mnuProductos_Click;
            // 
            // mnuClientes
            // 
            mnuClientes.Name = "mnuClientes";
            mnuClientes.Size = new Size(130, 22);
            mnuClientes.Text = "Clientes";
            // 
            // mnuOperaciones
            // 
            mnuOperaciones.DropDownItems.AddRange(new ToolStripItem[] { mnuVentas });
            mnuOperaciones.Name = "mnuOperaciones";
            mnuOperaciones.Size = new Size(85, 20);
            mnuOperaciones.Text = "Operaciones";
            // 
            // mnuVentas
            // 
            mnuVentas.Name = "mnuVentas";
            mnuVentas.Size = new Size(108, 22);
            mnuVentas.Text = "Ventas";
            // 
            // stsEstado
            // 
            stsEstado.Items.AddRange(new ToolStripItem[] { lblEstado, lblFecha });
            stsEstado.Location = new Point(0, 659);
            stsEstado.Name = "stsEstado";
            stsEstado.Size = new Size(1184, 22);
            stsEstado.TabIndex = 1;
            stsEstado.Text = "statusStrip1";
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.FromArgb(0, 0, 64);
            pnlMenuLateral.Controls.Add(btnVentas);
            pnlMenuLateral.Controls.Add(btnClientes);
            pnlMenuLateral.Controls.Add(btnProductos);
            pnlMenuLateral.Controls.Add(btnCategorias);
            pnlMenuLateral.Controls.Add(label2);
            pnlMenuLateral.Controls.Add(label1);
            pnlMenuLateral.Location = new Point(0, 27);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(240, 629);
            pnlMenuLateral.TabIndex = 2;
            // 
            // btnVentas
            // 
            btnVentas.Cursor = Cursors.Hand;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(-3, 352);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(240, 84);
            btnVentas.TabIndex = 5;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.Cursor = Cursors.Hand;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnClientes.ForeColor = Color.White;
            btnClientes.Location = new Point(0, 272);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(240, 84);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            btnProductos.Cursor = Cursors.Hand;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(-3, 188);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(240, 84);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(0, 107);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(240, 84);
            btnCategorias.TabIndex = 2;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(220, 25);
            label2.TabIndex = 1;
            label2.Text = "Menú Principal";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(220, 50);
            label1.TabIndex = 0;
            label1.Text = "MiTiendaPOS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.White;
            picLogo.Image = Properties.Resources.logo_MiTiendaPOS;
            picLogo.Location = new Point(246, 27);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(938, 629);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(1123, 17);
            lblEstado.Spring = true;
            lblEstado.Text = "Listo!";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(46, 17);
            lblFecha.Text = "(Fecha)";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 681);
            Controls.Add(picLogo);
            Controls.Add(pnlMenuLateral);
            Controls.Add(stsEstado);
            Controls.Add(mnuPrincipal);
            MainMenuStrip = mnuPrincipal;
            MinimumSize = new Size(1000, 650);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MITiendaPOS - Sistema de Punto de Venta";
            Load += Form1_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            stsEstado.ResumeLayout(false);
            stsEstado.PerformLayout();
            pnlMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private StatusStrip stsEstado;
        private Panel pnlMenuLateral;
        private PictureBox picLogo;
        private ToolStripMenuItem mnuSalir;
        private ToolStripMenuItem mnuCatalogos;
        private ToolStripMenuItem mnuCategorias;
        private ToolStripMenuItem mnuProductos;
        private ToolStripMenuItem mnuClientes;
        private ToolStripMenuItem mnuOperaciones;
        private ToolStripMenuItem mnuVentas;
        private Label label1;
        private Label label2;
        private Button btnCategorias;
        private Button btnVentas;
        private Button btnClientes;
        private Button btnProductos;
        private ToolStripStatusLabel lblEstado;
        private ToolStripStatusLabel lblFecha;
    }
}
