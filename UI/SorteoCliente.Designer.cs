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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_AgregarPasajero = new System.Windows.Forms.Button();
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.btn_RealizarSorteo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_ClientesGanadores = new System.Windows.Forms.DataGridView();
            this.lbx_GanadorSorteo = new System.Windows.Forms.ListBox();
            this.gb_Ayuda = new System.Windows.Forms.GroupBox();
            this.lbl_Ayuda = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClientesGanadores)).BeginInit();
            this.gb_Ayuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 55);
            this.button1.TabIndex = 17;
            this.button1.Text = "VER LISTA DE GANADORES";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_AgregarPasajero
            // 
            this.btn_AgregarPasajero.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_AgregarPasajero.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarPasajero.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarPasajero.Location = new System.Drawing.Point(16, 259);
            this.btn_AgregarPasajero.Name = "btn_AgregarPasajero";
            this.btn_AgregarPasajero.Size = new System.Drawing.Size(174, 44);
            this.btn_AgregarPasajero.TabIndex = 16;
            this.btn_AgregarPasajero.Text = "AGREGAR PASAJERO";
            this.btn_AgregarPasajero.UseVisualStyleBackColor = false;
            this.btn_AgregarPasajero.Click += new System.EventHandler(this.btn_AgregarPasajero_Click);
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToOrderColumns = true;
            this.dtg_Datos.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(12, 12);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(819, 150);
            this.dtg_Datos.TabIndex = 15;
            // 
            // btn_RealizarSorteo
            // 
            this.btn_RealizarSorteo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_RealizarSorteo.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RealizarSorteo.ForeColor = System.Drawing.Color.White;
            this.btn_RealizarSorteo.Location = new System.Drawing.Point(12, 191);
            this.btn_RealizarSorteo.Name = "btn_RealizarSorteo";
            this.btn_RealizarSorteo.Size = new System.Drawing.Size(178, 49);
            this.btn_RealizarSorteo.TabIndex = 14;
            this.btn_RealizarSorteo.Text = "REALIZAR SORTEO";
            this.btn_RealizarSorteo.UseVisualStyleBackColor = false;
            this.btn_RealizarSorteo.Click += new System.EventHandler(this.btn_RealizarSorteo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Clientes ganadores del sorteo";
            // 
            // dtg_ClientesGanadores
            // 
            this.dtg_ClientesGanadores.AllowUserToOrderColumns = true;
            this.dtg_ClientesGanadores.BackgroundColor = System.Drawing.Color.White;
            this.dtg_ClientesGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ClientesGanadores.Location = new System.Drawing.Point(386, 215);
            this.dtg_ClientesGanadores.Name = "dtg_ClientesGanadores";
            this.dtg_ClientesGanadores.RowTemplate.Height = 25;
            this.dtg_ClientesGanadores.Size = new System.Drawing.Size(245, 145);
            this.dtg_ClientesGanadores.TabIndex = 19;
            // 
            // lbx_GanadorSorteo
            // 
            this.lbx_GanadorSorteo.FormattingEnabled = true;
            this.lbx_GanadorSorteo.ItemHeight = 15;
            this.lbx_GanadorSorteo.Location = new System.Drawing.Point(218, 191);
            this.lbx_GanadorSorteo.Name = "lbx_GanadorSorteo";
            this.lbx_GanadorSorteo.Size = new System.Drawing.Size(162, 169);
            this.lbx_GanadorSorteo.TabIndex = 18;
            // 
            // gb_Ayuda
            // 
            this.gb_Ayuda.BackColor = System.Drawing.Color.White;
            this.gb_Ayuda.Controls.Add(this.lbl_Ayuda);
            this.gb_Ayuda.Location = new System.Drawing.Point(660, 215);
            this.gb_Ayuda.Name = "gb_Ayuda";
            this.gb_Ayuda.Size = new System.Drawing.Size(165, 145);
            this.gb_Ayuda.TabIndex = 23;
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
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(750, 189);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ayuda.TabIndex = 22;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(750, 407);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 31);
            this.btn_Salir.TabIndex = 21;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.BackColor = System.Drawing.Color.White;
            this.lbl_Mensaje.Location = new System.Drawing.Point(17, 426);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(10, 15);
            this.lbl_Mensaje.TabIndex = 24;
            this.lbl_Mensaje.Text = ".";
            // 
            // SorteoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(837, 450);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.gb_Ayuda);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_ClientesGanadores);
            this.Controls.Add(this.lbx_GanadorSorteo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AgregarPasajero);
            this.Controls.Add(this.dtg_Datos);
            this.Controls.Add(this.btn_RealizarSorteo);
            this.Name = "SorteoCliente";
            this.Text = "SorteoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ClientesGanadores)).EndInit();
            this.gb_Ayuda.ResumeLayout(false);
            this.gb_Ayuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_AgregarPasajero;
        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.Button btn_RealizarSorteo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_ClientesGanadores;
        private System.Windows.Forms.ListBox lbx_GanadorSorteo;
        private System.Windows.Forms.GroupBox gb_Ayuda;
        private System.Windows.Forms.Label lbl_Ayuda;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Mensaje;
    }
}