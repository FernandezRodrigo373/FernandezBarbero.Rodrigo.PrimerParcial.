namespace UI
{
    partial class CrearVuelos
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
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.txb_Piloto = new System.Windows.Forms.TextBox();
            this.lbl_Aviones = new System.Windows.Forms.Label();
            this.cmb_Avion = new System.Windows.Forms.ComboBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.gb_Ayuda = new System.Windows.Forms.GroupBox();
            this.lbl_Ayuda = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.lbl_Mensaje = new System.Windows.Forms.Label();
            this.gb_Ayuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Origen.ForeColor = System.Drawing.Color.White;
            this.lbl_Origen.Location = new System.Drawing.Point(12, 18);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(128, 15);
            this.lbl_Origen.TabIndex = 14;
            this.lbl_Origen.Text = "SELECCIONAR ORIGEN";
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Origen.BackColor = System.Drawing.Color.White;
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(14, 36);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(239, 23);
            this.cmb_Origen.TabIndex = 13;
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Destino.ForeColor = System.Drawing.Color.White;
            this.lbl_Destino.Location = new System.Drawing.Point(12, 67);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(133, 15);
            this.lbl_Destino.TabIndex = 12;
            this.lbl_Destino.Text = "SELECCIONAR DESTINO";
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Destino.BackColor = System.Drawing.Color.White;
            this.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(14, 85);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(239, 23);
            this.cmb_Destino.TabIndex = 11;
            this.cmb_Destino.SelectedIndexChanged += new System.EventHandler(this.cmb_Destino_SelectedIndexChanged);
            // 
            // txb_Piloto
            // 
            this.txb_Piloto.Location = new System.Drawing.Point(154, 206);
            this.txb_Piloto.Name = "txb_Piloto";
            this.txb_Piloto.PlaceholderText = "Piloto";
            this.txb_Piloto.Size = new System.Drawing.Size(100, 23);
            this.txb_Piloto.TabIndex = 18;
            // 
            // lbl_Aviones
            // 
            this.lbl_Aviones.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Aviones.ForeColor = System.Drawing.Color.White;
            this.lbl_Aviones.Location = new System.Drawing.Point(10, 175);
            this.lbl_Aviones.Name = "lbl_Aviones";
            this.lbl_Aviones.Size = new System.Drawing.Size(127, 15);
            this.lbl_Aviones.TabIndex = 17;
            this.lbl_Aviones.Text = "AVIONES DISPONIBLES";
            // 
            // cmb_Avion
            // 
            this.cmb_Avion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Avion.BackColor = System.Drawing.Color.White;
            this.cmb_Avion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Avion.FormattingEnabled = true;
            this.cmb_Avion.Location = new System.Drawing.Point(12, 206);
            this.cmb_Avion.Name = "cmb_Avion";
            this.cmb_Avion.Size = new System.Drawing.Size(121, 23);
            this.cmb_Avion.TabIndex = 16;
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_Fecha.Location = new System.Drawing.Point(12, 130);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(239, 23);
            this.dtp_Fecha.TabIndex = 15;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.BackColor = System.Drawing.Color.White;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Salir.Location = new System.Drawing.Point(382, 306);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 36);
            this.btn_Salir.TabIndex = 20;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Agregar.BackColor = System.Drawing.Color.White;
            this.btn_Agregar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Agregar.Location = new System.Drawing.Point(14, 262);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(239, 35);
            this.btn_Agregar.TabIndex = 19;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ayuda.Location = new System.Drawing.Point(370, 18);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ayuda.TabIndex = 22;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // gb_Ayuda
            // 
            this.gb_Ayuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Ayuda.BackColor = System.Drawing.Color.White;
            this.gb_Ayuda.Controls.Add(this.lbl_Ayuda);
            this.gb_Ayuda.Location = new System.Drawing.Point(277, 47);
            this.gb_Ayuda.Name = "gb_Ayuda";
            this.gb_Ayuda.Size = new System.Drawing.Size(176, 186);
            this.gb_Ayuda.TabIndex = 21;
            this.gb_Ayuda.TabStop = false;
            this.gb_Ayuda.Text = "Ayuda";
            // 
            // lbl_Ayuda
            // 
            this.lbl_Ayuda.AutoSize = true;
            this.lbl_Ayuda.BackColor = System.Drawing.Color.White;
            this.lbl_Ayuda.Location = new System.Drawing.Point(5, 28);
            this.lbl_Ayuda.Name = "lbl_Ayuda";
            this.lbl_Ayuda.Size = new System.Drawing.Size(10, 15);
            this.lbl_Ayuda.TabIndex = 0;
            this.lbl_Ayuda.Text = ".";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Location = new System.Drawing.Point(10, 330);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(10, 15);
            this.lbl_Error.TabIndex = 23;
            this.lbl_Error.Text = ".";
            // 
            // lbl_Mensaje
            // 
            this.lbl_Mensaje.AutoSize = true;
            this.lbl_Mensaje.Location = new System.Drawing.Point(10, 306);
            this.lbl_Mensaje.Name = "lbl_Mensaje";
            this.lbl_Mensaje.Size = new System.Drawing.Size(10, 15);
            this.lbl_Mensaje.TabIndex = 24;
            this.lbl_Mensaje.Text = ".";
            // 
            // CrearVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(469, 354);
            this.Controls.Add(this.lbl_Mensaje);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.gb_Ayuda);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txb_Piloto);
            this.Controls.Add(this.lbl_Aviones);
            this.Controls.Add(this.cmb_Avion);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.lbl_Origen);
            this.Controls.Add(this.cmb_Origen);
            this.Controls.Add(this.lbl_Destino);
            this.Controls.Add(this.cmb_Destino);
            this.Name = "CrearVuelos";
            this.Text = "CrearVuelos";
            this.Load += new System.EventHandler(this.CrearVuelos_Load_1);
            this.gb_Ayuda.ResumeLayout(false);
            this.gb_Ayuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Origen;
        private System.Windows.Forms.ComboBox cmb_Origen;
        private System.Windows.Forms.Label lbl_Destino;
        private System.Windows.Forms.ComboBox cmb_Destino;
        private System.Windows.Forms.TextBox txb_Piloto;
        private System.Windows.Forms.Label lbl_Aviones;
        private System.Windows.Forms.ComboBox cmb_Avion;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.GroupBox gb_Ayuda;
        private System.Windows.Forms.Label lbl_Ayuda;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Label lbl_Mensaje;
    }
}