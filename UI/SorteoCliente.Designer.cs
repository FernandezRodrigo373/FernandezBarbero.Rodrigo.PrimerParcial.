namespace UI
{
    partial class SorteoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SorteoCliente));
            this.btn_RealizarSorteo = new System.Windows.Forms.Button();
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbx_GanadorSorteo = new System.Windows.Forms.ListBox();
            this.btn_AgregarPasajero = new System.Windows.Forms.Button();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.gb_Ayuda = new System.Windows.Forms.GroupBox();
            this.lbl_Ayuda = new System.Windows.Forms.Label();
            this.dtg_ClientesGanadores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            this.gb_Ayuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClientesGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RealizarSorteo
            // 
            this.btn_RealizarSorteo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_RealizarSorteo.ForeColor = System.Drawing.Color.White;
            this.btn_RealizarSorteo.Location = new System.Drawing.Point(23, 210);
            this.btn_RealizarSorteo.Name = "btn_RealizarSorteo";
            this.btn_RealizarSorteo.Size = new System.Drawing.Size(178, 49);
            this.btn_RealizarSorteo.TabIndex = 0;
            this.btn_RealizarSorteo.Text = "Realizar sorteo";
            this.btn_RealizarSorteo.UseVisualStyleBackColor = false;
            this.btn_RealizarSorteo.Click += new System.EventHandler(this.btn_RealizarSorteo_Click);
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToOrderColumns = true;
            this.dtg_Datos.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(23, 31);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(819, 150);
            this.dtg_Datos.TabIndex = 2;
            this.dtg_Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Datos_CellContentClick);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(767, 402);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 31);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbx_GanadorSorteo
            // 
            this.lbx_GanadorSorteo.FormattingEnabled = true;
            this.lbx_GanadorSorteo.ItemHeight = 15;
            this.lbx_GanadorSorteo.Location = new System.Drawing.Point(242, 210);
            this.lbx_GanadorSorteo.Name = "lbx_GanadorSorteo";
            this.lbx_GanadorSorteo.Size = new System.Drawing.Size(162, 169);
            this.lbx_GanadorSorteo.TabIndex = 6;
            // 
            // btn_AgregarPasajero
            // 
            this.btn_AgregarPasajero.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_AgregarPasajero.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarPasajero.Location = new System.Drawing.Point(27, 278);
            this.btn_AgregarPasajero.Name = "btn_AgregarPasajero";
            this.btn_AgregarPasajero.Size = new System.Drawing.Size(174, 44);
            this.btn_AgregarPasajero.TabIndex = 7;
            this.btn_AgregarPasajero.Text = "Agregar pasajero";
            this.btn_AgregarPasajero.UseVisualStyleBackColor = false;
            this.btn_AgregarPasajero.Click += new System.EventHandler(this.btn_AgregarPasajero_Click);
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.BackColor = System.Drawing.Color.White;
            this.lbl_Mensaje.Location = new System.Drawing.Point(23, 410);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(10, 15);
            this.lbl_Mensaje.TabIndex = 8;
            this.lbl_Mensaje.Text = ".";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(767, 208);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ayuda.TabIndex = 9;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // gb_Ayuda
            // 
            this.gb_Ayuda.BackColor = System.Drawing.Color.White;
            this.gb_Ayuda.Controls.Add(this.lbl_Ayuda);
            this.gb_Ayuda.Location = new System.Drawing.Point(677, 234);
            this.gb_Ayuda.Name = "gb_Ayuda";
            this.gb_Ayuda.Size = new System.Drawing.Size(165, 145);
            this.gb_Ayuda.TabIndex = 10;
            this.gb_Ayuda.TabStop = false;
            this.gb_Ayuda.Text = "Ayuda";
            // 
            // lbl_Ayuda
            // 
            this.lbl_Ayuda.AutoSize = true;
            this.lbl_Ayuda.Location = new System.Drawing.Point(10, 25);
            this.lbl_Ayuda.Name = "lbl_Ayuda";
            this.lbl_Ayuda.Size = new System.Drawing.Size(10, 15);
            this.lbl_Ayuda.TabIndex = 0;
            this.lbl_Ayuda.Text = ".";
            // 
            // dtg_ClientesGanadores
            // 
            this.dtg_ClientesGanadores.AllowUserToOrderColumns = true;
            this.dtg_ClientesGanadores.BackgroundColor = System.Drawing.Color.White;
            this.dtg_ClientesGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ClientesGanadores.Location = new System.Drawing.Point(410, 234);
            this.dtg_ClientesGanadores.Name = "dtg_ClientesGanadores";
            this.dtg_ClientesGanadores.RowTemplate.Height = 25;
            this.dtg_ClientesGanadores.Size = new System.Drawing.Size(245, 145);
            this.dtg_ClientesGanadores.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clientes ganadores del sorteo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(28, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Ver lista de Ganadores";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SorteoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 445);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_ClientesGanadores);
            this.Controls.Add(this.gb_Ayuda);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.btn_AgregarPasajero);
            this.Controls.Add(this.lbx_GanadorSorteo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.dtg_Datos);
            this.Controls.Add(this.btn_RealizarSorteo);
            this.DoubleBuffered = true;
            this.Name = "SorteoCliente";
            this.Text = "SorteoCliente";
            this.Load += new System.EventHandler(this.SorteoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.gb_Ayuda.ResumeLayout(false);
            this.gb_Ayuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClientesGanadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RealizarSorteo;
        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.DataGridView dtg_Datos2;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lbx_GanadorSorteo;
        private System.Windows.Forms.Button btn_AgregarPasajero;
        private System.Windows.Forms.Label lbl_Mensaje;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.GroupBox gb_Ayuda;
        private System.Windows.Forms.Label lbl_Ayuda;
        private System.Windows.Forms.DataGridView dtg_ClientesGanadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}