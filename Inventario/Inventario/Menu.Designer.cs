namespace Inventario
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuLateral = new System.Windows.Forms.Panel();
            this.panelreportes = new System.Windows.Forms.Panel();
            this.btnRT = new System.Windows.Forms.Button();
            this.btnRP = new System.Windows.Forms.Button();
            this.btnRC = new System.Windows.Forms.Button();
            this.btnRVenta = new System.Windows.Forms.Button();
            this.panelreporteI = new System.Windows.Forms.Panel();
            this.btnRProducto = new System.Windows.Forms.Button();
            this.btnRCliente = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.panelsubmenuventas = new System.Windows.Forms.Panel();
            this.btnVen = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelhorafecha = new System.Windows.Forms.Panel();
            this.panelformhijo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.MenuLateral.SuspendLayout();
            this.panelreportes.SuspendLayout();
            this.panelreporteI.SuspendLayout();
            this.panelsubmenuventas.SuspendLayout();
            this.panelhorafecha.SuspendLayout();
            this.panelformhijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuLateral
            // 
            this.MenuLateral.AutoScroll = true;
            this.MenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.MenuLateral.Controls.Add(this.panelreportes);
            this.MenuLateral.Controls.Add(this.btnRVenta);
            this.MenuLateral.Controls.Add(this.panelreporteI);
            this.MenuLateral.Controls.Add(this.btnReporte);
            this.MenuLateral.Controls.Add(this.panelsubmenuventas);
            this.MenuLateral.Controls.Add(this.btnVentas);
            this.MenuLateral.Controls.Add(this.panel1);
            this.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLateral.Location = new System.Drawing.Point(0, 0);
            this.MenuLateral.Name = "MenuLateral";
            this.MenuLateral.Size = new System.Drawing.Size(250, 561);
            this.MenuLateral.TabIndex = 0;
            // 
            // panelreportes
            // 
            this.panelreportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelreportes.Controls.Add(this.btnRT);
            this.panelreportes.Controls.Add(this.btnRP);
            this.panelreportes.Controls.Add(this.btnRC);
            this.panelreportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelreportes.Location = new System.Drawing.Point(0, 490);
            this.panelreportes.Name = "panelreportes";
            this.panelreportes.Size = new System.Drawing.Size(233, 122);
            this.panelreportes.TabIndex = 6;
            // 
            // btnRT
            // 
            this.btnRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRT.FlatAppearance.BorderSize = 0;
            this.btnRT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRT.ForeColor = System.Drawing.Color.White;
            this.btnRT.Location = new System.Drawing.Point(0, 80);
            this.btnRT.Name = "btnRT";
            this.btnRT.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRT.Size = new System.Drawing.Size(233, 40);
            this.btnRT.TabIndex = 2;
            this.btnRT.Text = "Reportes Totales";
            this.btnRT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRT.UseVisualStyleBackColor = true;
            this.btnRT.Click += new System.EventHandler(this.btnRT_Click);
            // 
            // btnRP
            // 
            this.btnRP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRP.FlatAppearance.BorderSize = 0;
            this.btnRP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRP.ForeColor = System.Drawing.Color.White;
            this.btnRP.Location = new System.Drawing.Point(0, 40);
            this.btnRP.Name = "btnRP";
            this.btnRP.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRP.Size = new System.Drawing.Size(233, 40);
            this.btnRP.TabIndex = 1;
            this.btnRP.Text = "Por Productos";
            this.btnRP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRP.UseVisualStyleBackColor = true;
            this.btnRP.Click += new System.EventHandler(this.btnRP_Click);
            // 
            // btnRC
            // 
            this.btnRC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRC.FlatAppearance.BorderSize = 0;
            this.btnRC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRC.ForeColor = System.Drawing.Color.White;
            this.btnRC.Location = new System.Drawing.Point(0, 0);
            this.btnRC.Name = "btnRC";
            this.btnRC.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRC.Size = new System.Drawing.Size(233, 40);
            this.btnRC.TabIndex = 0;
            this.btnRC.Text = "Por Cliente";
            this.btnRC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRC.UseVisualStyleBackColor = true;
            this.btnRC.Click += new System.EventHandler(this.btnRC_Click);
            // 
            // btnRVenta
            // 
            this.btnRVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRVenta.FlatAppearance.BorderSize = 0;
            this.btnRVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRVenta.ForeColor = System.Drawing.Color.White;
            this.btnRVenta.Location = new System.Drawing.Point(0, 445);
            this.btnRVenta.Name = "btnRVenta";
            this.btnRVenta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRVenta.Size = new System.Drawing.Size(233, 45);
            this.btnRVenta.TabIndex = 5;
            this.btnRVenta.Text = "Reporte Ventas";
            this.btnRVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRVenta.UseVisualStyleBackColor = true;
            this.btnRVenta.Click += new System.EventHandler(this.btnRVenta_Click);
            // 
            // panelreporteI
            // 
            this.panelreporteI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelreporteI.Controls.Add(this.btnRProducto);
            this.panelreporteI.Controls.Add(this.btnRCliente);
            this.panelreporteI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelreporteI.Location = new System.Drawing.Point(0, 357);
            this.panelreporteI.Name = "panelreporteI";
            this.panelreporteI.Size = new System.Drawing.Size(233, 88);
            this.panelreporteI.TabIndex = 4;
            // 
            // btnRProducto
            // 
            this.btnRProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRProducto.FlatAppearance.BorderSize = 0;
            this.btnRProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRProducto.ForeColor = System.Drawing.Color.White;
            this.btnRProducto.Location = new System.Drawing.Point(0, 40);
            this.btnRProducto.Name = "btnRProducto";
            this.btnRProducto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRProducto.Size = new System.Drawing.Size(233, 40);
            this.btnRProducto.TabIndex = 1;
            this.btnRProducto.Text = "Reporte Productos";
            this.btnRProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRProducto.UseVisualStyleBackColor = true;
            this.btnRProducto.Click += new System.EventHandler(this.btnRProducto_Click);
            // 
            // btnRCliente
            // 
            this.btnRCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRCliente.FlatAppearance.BorderSize = 0;
            this.btnRCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnRCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCliente.ForeColor = System.Drawing.Color.White;
            this.btnRCliente.Location = new System.Drawing.Point(0, 0);
            this.btnRCliente.Name = "btnRCliente";
            this.btnRCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRCliente.Size = new System.Drawing.Size(233, 40);
            this.btnRCliente.TabIndex = 0;
            this.btnRCliente.Text = "Reporte Cliente";
            this.btnRCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRCliente.UseVisualStyleBackColor = true;
            this.btnRCliente.Click += new System.EventHandler(this.btnRCliente_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(0, 312);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReporte.Size = new System.Drawing.Size(233, 45);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Reporte Individual";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // panelsubmenuventas
            // 
            this.panelsubmenuventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelsubmenuventas.Controls.Add(this.btnVen);
            this.panelsubmenuventas.Controls.Add(this.btnFacturas);
            this.panelsubmenuventas.Controls.Add(this.btnClientes);
            this.panelsubmenuventas.Controls.Add(this.btnProductos);
            this.panelsubmenuventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsubmenuventas.Location = new System.Drawing.Point(0, 145);
            this.panelsubmenuventas.Name = "panelsubmenuventas";
            this.panelsubmenuventas.Size = new System.Drawing.Size(233, 167);
            this.panelsubmenuventas.TabIndex = 2;
            // 
            // btnVen
            // 
            this.btnVen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVen.FlatAppearance.BorderSize = 0;
            this.btnVen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnVen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVen.ForeColor = System.Drawing.Color.White;
            this.btnVen.Location = new System.Drawing.Point(0, 120);
            this.btnVen.Name = "btnVen";
            this.btnVen.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVen.Size = new System.Drawing.Size(233, 40);
            this.btnVen.TabIndex = 3;
            this.btnVen.Text = "Ventas";
            this.btnVen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVen.UseVisualStyleBackColor = true;
            this.btnVen.Click += new System.EventHandler(this.btnVen_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFacturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Location = new System.Drawing.Point(0, 80);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFacturas.Size = new System.Drawing.Size(233, 40);
            this.btnFacturas.TabIndex = 2;
            this.btnFacturas.Text = "Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 40);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(233, 40);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(233, 40);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(0, 100);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(233, 45);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "VentasMenu";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 100);
            this.panel1.TabIndex = 0;
            // 
            // panelhorafecha
            // 
            this.panelhorafecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelhorafecha.Controls.Add(this.btnsalir);
            this.panelhorafecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelhorafecha.Location = new System.Drawing.Point(250, 507);
            this.panelhorafecha.Name = "panelhorafecha";
            this.panelhorafecha.Size = new System.Drawing.Size(684, 54);
            this.panelhorafecha.TabIndex = 1;
            // 
            // panelformhijo
            // 
            this.panelformhijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelformhijo.Controls.Add(this.pictureBox1);
            this.panelformhijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelformhijo.Location = new System.Drawing.Point(250, 0);
            this.panelformhijo.Name = "panelformhijo";
            this.panelformhijo.Size = new System.Drawing.Size(684, 507);
            this.panelformhijo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Location = new System.Drawing.Point(628, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnsalir.Size = new System.Drawing.Size(56, 54);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelformhijo);
            this.Controls.Add(this.panelhorafecha);
            this.Controls.Add(this.MenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Menu";
            this.Text = "Menu";
            this.MenuLateral.ResumeLayout(false);
            this.panelreportes.ResumeLayout(false);
            this.panelreporteI.ResumeLayout(false);
            this.panelsubmenuventas.ResumeLayout(false);
            this.panelhorafecha.ResumeLayout(false);
            this.panelformhijo.ResumeLayout(false);
            this.panelformhijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuLateral;
        private System.Windows.Forms.Panel panelsubmenuventas;
        private System.Windows.Forms.Button btnVen;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelreportes;
        private System.Windows.Forms.Button btnRT;
        private System.Windows.Forms.Button btnRP;
        private System.Windows.Forms.Button btnRC;
        private System.Windows.Forms.Button btnRVenta;
        private System.Windows.Forms.Panel panelreporteI;
        private System.Windows.Forms.Button btnRProducto;
        private System.Windows.Forms.Button btnRCliente;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Panel panelhorafecha;
        private System.Windows.Forms.Panel panelformhijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsalir;
    }
}