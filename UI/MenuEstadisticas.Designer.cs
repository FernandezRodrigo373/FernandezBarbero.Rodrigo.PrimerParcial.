namespace UI
{
    partial class MenuEstadisticas
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
            this.btn_ListaDeDestinos = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.lbl_DestinoMasElegido = new System.Windows.Forms.Label();
            this.btn_Ganancias = new System.Windows.Forms.Button();
            this.lbl_Totales = new System.Windows.Forms.Label();
            this.lbl_GananciasNacionales = new System.Windows.Forms.Label();
            this.lbl_GananciasInternacionales = new System.Windows.Forms.Label();
            this.btn_HorasDeVuelo = new System.Windows.Forms.Button();
            this.btn_PasajerosPorCantDeVuelos = new System.Windows.Forms.Button();
            this.btn_OrdenarDeManeraAscendente = new System.Windows.Forms.Button();
            this.btn_OrdenarDeManeraDescendente = new System.Windows.Forms.Button();
            this.btn_ListaDeDestinosPorFacturacion = new System.Windows.Forms.Button();
            this.gb_Ayuda = new System.Windows.Forms.GroupBox();
            this.lbl_Ayuda = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            this.gb_Ayuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ListaDeDestinos
            // 
            this.btn_ListaDeDestinos.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_ListaDeDestinos.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ListaDeDestinos.ForeColor = System.Drawing.Color.White;
            this.btn_ListaDeDestinos.Location = new System.Drawing.Point(12, 12);
            this.btn_ListaDeDestinos.Name = "btn_ListaDeDestinos";
            this.btn_ListaDeDestinos.Size = new System.Drawing.Size(257, 42);
            this.btn_ListaDeDestinos.TabIndex = 0;
            this.btn_ListaDeDestinos.Text = "Destino mas elegido";
            this.btn_ListaDeDestinos.UseVisualStyleBackColor = false;
            this.btn_ListaDeDestinos.Click += new System.EventHandler(this.btn_ListaDeDestinos_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(713, 409);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 29);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToOrderColumns = true;
            this.dtg_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtg_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dtg_Datos.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(337, 12);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(451, 174);
            this.dtg_Datos.TabIndex = 3;
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Finalizar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Finalizar.ForeColor = System.Drawing.Color.White;
            this.btn_Finalizar.Location = new System.Drawing.Point(648, 353);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(140, 50);
            this.btn_Finalizar.TabIndex = 4;
            this.btn_Finalizar.Text = "Finalizar operaciones";
            this.btn_Finalizar.UseVisualStyleBackColor = false;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // lbl_DestinoMasElegido
            // 
            this.lbl_DestinoMasElegido.AutoSize = true;
            this.lbl_DestinoMasElegido.Location = new System.Drawing.Point(321, 210);
            this.lbl_DestinoMasElegido.Name = "lbl_DestinoMasElegido";
            this.lbl_DestinoMasElegido.Size = new System.Drawing.Size(10, 15);
            this.lbl_DestinoMasElegido.TabIndex = 5;
            this.lbl_DestinoMasElegido.Text = ".";
            // 
            // btn_Ganancias
            // 
            this.btn_Ganancias.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Ganancias.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ganancias.ForeColor = System.Drawing.Color.White;
            this.btn_Ganancias.Location = new System.Drawing.Point(12, 78);
            this.btn_Ganancias.Name = "btn_Ganancias";
            this.btn_Ganancias.Size = new System.Drawing.Size(257, 42);
            this.btn_Ganancias.TabIndex = 6;
            this.btn_Ganancias.Text = "Ganancias";
            this.btn_Ganancias.UseVisualStyleBackColor = false;
            this.btn_Ganancias.Click += new System.EventHandler(this.btn_Ganancias_Click);
            // 
            // lbl_Totales
            // 
            this.lbl_Totales.AutoSize = true;
            this.lbl_Totales.Location = new System.Drawing.Point(321, 248);
            this.lbl_Totales.Name = "lbl_Totales";
            this.lbl_Totales.Size = new System.Drawing.Size(10, 15);
            this.lbl_Totales.TabIndex = 7;
            this.lbl_Totales.Text = ".";
            // 
            // lbl_GananciasNacionales
            // 
            this.lbl_GananciasNacionales.AutoSize = true;
            this.lbl_GananciasNacionales.Location = new System.Drawing.Point(321, 277);
            this.lbl_GananciasNacionales.Name = "lbl_GananciasNacionales";
            this.lbl_GananciasNacionales.Size = new System.Drawing.Size(10, 15);
            this.lbl_GananciasNacionales.TabIndex = 8;
            this.lbl_GananciasNacionales.Text = ".";
            // 
            // lbl_GananciasInternacionales
            // 
            this.lbl_GananciasInternacionales.AutoSize = true;
            this.lbl_GananciasInternacionales.Location = new System.Drawing.Point(321, 318);
            this.lbl_GananciasInternacionales.Name = "lbl_GananciasInternacionales";
            this.lbl_GananciasInternacionales.Size = new System.Drawing.Size(10, 15);
            this.lbl_GananciasInternacionales.TabIndex = 9;
            this.lbl_GananciasInternacionales.Text = ".";
            // 
            // btn_HorasDeVuelo
            // 
            this.btn_HorasDeVuelo.BackColor = System.Drawing.Color.Crimson;
            this.btn_HorasDeVuelo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_HorasDeVuelo.ForeColor = System.Drawing.Color.White;
            this.btn_HorasDeVuelo.Location = new System.Drawing.Point(12, 146);
            this.btn_HorasDeVuelo.Name = "btn_HorasDeVuelo";
            this.btn_HorasDeVuelo.Size = new System.Drawing.Size(257, 40);
            this.btn_HorasDeVuelo.TabIndex = 10;
            this.btn_HorasDeVuelo.Text = "Horas de Vuelo";
            this.btn_HorasDeVuelo.UseVisualStyleBackColor = false;
            this.btn_HorasDeVuelo.Click += new System.EventHandler(this.btn_HorasDeVuelo_Click);
            // 
            // btn_PasajerosPorCantDeVuelos
            // 
            this.btn_PasajerosPorCantDeVuelos.BackColor = System.Drawing.Color.Magenta;
            this.btn_PasajerosPorCantDeVuelos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_PasajerosPorCantDeVuelos.Location = new System.Drawing.Point(17, 210);
            this.btn_PasajerosPorCantDeVuelos.Name = "btn_PasajerosPorCantDeVuelos";
            this.btn_PasajerosPorCantDeVuelos.Size = new System.Drawing.Size(252, 53);
            this.btn_PasajerosPorCantDeVuelos.TabIndex = 11;
            this.btn_PasajerosPorCantDeVuelos.Text = "Pasajeros ordenados por cantidad de vuelos";
            this.btn_PasajerosPorCantDeVuelos.UseVisualStyleBackColor = false;
            this.btn_PasajerosPorCantDeVuelos.Click += new System.EventHandler(this.btn_PasajerosPorCantDeVuelos_Click);
            // 
            // btn_OrdenarDeManeraAscendente
            // 
            this.btn_OrdenarDeManeraAscendente.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_OrdenarDeManeraAscendente.ForeColor = System.Drawing.Color.White;
            this.btn_OrdenarDeManeraAscendente.Location = new System.Drawing.Point(55, 269);
            this.btn_OrdenarDeManeraAscendente.Name = "btn_OrdenarDeManeraAscendente";
            this.btn_OrdenarDeManeraAscendente.Size = new System.Drawing.Size(85, 23);
            this.btn_OrdenarDeManeraAscendente.TabIndex = 12;
            this.btn_OrdenarDeManeraAscendente.Text = "Ascendente";
            this.btn_OrdenarDeManeraAscendente.UseVisualStyleBackColor = false;
            this.btn_OrdenarDeManeraAscendente.Click += new System.EventHandler(this.btn_OrdenarDeManeraAscendente_Click);
            // 
            // btn_OrdenarDeManeraDescendente
            // 
            this.btn_OrdenarDeManeraDescendente.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_OrdenarDeManeraDescendente.ForeColor = System.Drawing.Color.White;
            this.btn_OrdenarDeManeraDescendente.Location = new System.Drawing.Point(146, 269);
            this.btn_OrdenarDeManeraDescendente.Name = "btn_OrdenarDeManeraDescendente";
            this.btn_OrdenarDeManeraDescendente.Size = new System.Drawing.Size(85, 23);
            this.btn_OrdenarDeManeraDescendente.TabIndex = 13;
            this.btn_OrdenarDeManeraDescendente.Text = "Descendente";
            this.btn_OrdenarDeManeraDescendente.UseVisualStyleBackColor = false;
            this.btn_OrdenarDeManeraDescendente.Click += new System.EventHandler(this.btn_OrdenarDeManeraDescendente_Click);
            // 
            // btn_ListaDeDestinosPorFacturacion
            // 
            this.btn_ListaDeDestinosPorFacturacion.BackColor = System.Drawing.Color.Orange;
            this.btn_ListaDeDestinosPorFacturacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ListaDeDestinosPorFacturacion.ForeColor = System.Drawing.Color.White;
            this.btn_ListaDeDestinosPorFacturacion.Location = new System.Drawing.Point(17, 313);
            this.btn_ListaDeDestinosPorFacturacion.Name = "btn_ListaDeDestinosPorFacturacion";
            this.btn_ListaDeDestinosPorFacturacion.Size = new System.Drawing.Size(252, 40);
            this.btn_ListaDeDestinosPorFacturacion.TabIndex = 14;
            this.btn_ListaDeDestinosPorFacturacion.Text = "Lista de destinos por facturacion";
            this.btn_ListaDeDestinosPorFacturacion.UseVisualStyleBackColor = false;
            this.btn_ListaDeDestinosPorFacturacion.Click += new System.EventHandler(this.btn_ListaDeDestinosPorFacturacion_Click);
            // 
            // gb_Ayuda
            // 
            this.gb_Ayuda.Controls.Add(this.lbl_Ayuda);
            this.gb_Ayuda.Location = new System.Drawing.Point(523, 200);
            this.gb_Ayuda.Name = "gb_Ayuda";
            this.gb_Ayuda.Size = new System.Drawing.Size(271, 112);
            this.gb_Ayuda.TabIndex = 15;
            this.gb_Ayuda.TabStop = false;
            this.gb_Ayuda.Text = "Ayuda";
            // 
            // lbl_Ayuda
            // 
            this.lbl_Ayuda.AutoSize = true;
            this.lbl_Ayuda.Location = new System.Drawing.Point(13, 13);
            this.lbl_Ayuda.Name = "lbl_Ayuda";
            this.lbl_Ayuda.Size = new System.Drawing.Size(10, 15);
            this.lbl_Ayuda.TabIndex = 0;
            this.lbl_Ayuda.Text = ".";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(713, 318);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ayuda.TabIndex = 16;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // MenuEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::UI.Properties.Resources.Captura;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.gb_Ayuda);
            this.Controls.Add(this.btn_ListaDeDestinosPorFacturacion);
            this.Controls.Add(this.btn_OrdenarDeManeraDescendente);
            this.Controls.Add(this.btn_OrdenarDeManeraAscendente);
            this.Controls.Add(this.btn_PasajerosPorCantDeVuelos);
            this.Controls.Add(this.btn_HorasDeVuelo);
            this.Controls.Add(this.lbl_GananciasInternacionales);
            this.Controls.Add(this.lbl_GananciasNacionales);
            this.Controls.Add(this.lbl_Totales);
            this.Controls.Add(this.btn_Ganancias);
            this.Controls.Add(this.lbl_DestinoMasElegido);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.dtg_Datos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_ListaDeDestinos);
            this.Name = "MenuEstadisticas";
            this.Text = "MenuEstadisticas";
            this.Load += new System.EventHandler(this.MenuEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.gb_Ayuda.ResumeLayout(false);
            this.gb_Ayuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ListaDeDestinos;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Label lbl_DestinoMasElegido;
        private System.Windows.Forms.Button btn_Ganancias;
        private System.Windows.Forms.Label lbl_Totales;
        private System.Windows.Forms.Label lbl_GananciasNacionales;
        private System.Windows.Forms.Label lbl_GananciasInternacionales;
        private System.Windows.Forms.Button btn_HorasDeVuelo;
        private System.Windows.Forms.Button btn_PasajerosPorCantDeVuelos;
        private System.Windows.Forms.Button btn_OrdenarDeManeraAscendente;
        private System.Windows.Forms.Button btn_OrdenarDeManeraDescendente;
        private System.Windows.Forms.Button btn_ListaDeDestinosPorFacturacion;
        private System.Windows.Forms.GroupBox gb_Ayuda;
        private System.Windows.Forms.Label lbl_Ayuda;
        private System.Windows.Forms.Button btn_Ayuda;
    }
}