namespace UI
{
    partial class AltaPasajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPasajero));
            this.gb_Clase = new System.Windows.Forms.GroupBox();
            this.rb_ClasePremium = new System.Windows.Forms.RadioButton();
            this.rb_ClaseTurista = new System.Windows.Forms.RadioButton();
            this.dtg_DatosAMostrar = new System.Windows.Forms.DataGridView();
            this.txb_NombreCliente = new System.Windows.Forms.TextBox();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.btn_BuscarVuelo = new System.Windows.Forms.Button();
            this.txb_IdVuelo = new System.Windows.Forms.TextBox();
            this.gb_EquipajeDeMano = new System.Windows.Forms.GroupBox();
            this.rb_NoLLevaBolsoDeMano = new System.Windows.Forms.RadioButton();
            this.rb_LlevaBolsoDeMano = new System.Windows.Forms.RadioButton();
            this.dtg_DatosAMostrar2 = new System.Windows.Forms.DataGridView();
            this.gb_Extras = new System.Windows.Forms.GroupBox();
            this.chb_Peliculas = new System.Windows.Forms.CheckBox();
            this.chb_Comida = new System.Windows.Forms.CheckBox();
            this.chb_Wifi = new System.Windows.Forms.CheckBox();
            this.btn_CalcularPrecio = new System.Windows.Forms.Button();
            this.lbl_PrecioBruto = new System.Windows.Forms.Label();
            this.btn_FinalizarOperacion = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.gb_Bodega = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_PesoValija2 = new System.Windows.Forms.TextBox();
            this.txb_PesoValija1 = new System.Windows.Forms.TextBox();
            this.lbl_TextoPrecioBruto = new System.Windows.Forms.Label();
            this.lbl_TextoPrecioNeto = new System.Windows.Forms.Label();
            this.lbl_PrecioNeto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ConfirmacionPasajero = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.gb_Ayuda = new System.Windows.Forms.GroupBox();
            this.lbl_Ayuda = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_CantPasajes4 = new System.Windows.Forms.RadioButton();
            this.rb_CantPasajes3 = new System.Windows.Forms.RadioButton();
            this.rb_CantPasajes2 = new System.Windows.Forms.RadioButton();
            this.rb_CantPasajes1 = new System.Windows.Forms.RadioButton();
            this.gb_Clase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DatosAMostrar)).BeginInit();
            this.gb_EquipajeDeMano.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DatosAMostrar2)).BeginInit();
            this.gb_Extras.SuspendLayout();
            this.gb_Bodega.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb_Ayuda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Clase
            // 
            this.gb_Clase.BackColor = System.Drawing.Color.SlateBlue;
            this.gb_Clase.Controls.Add(this.rb_ClasePremium);
            this.gb_Clase.Controls.Add(this.rb_ClaseTurista);
            this.gb_Clase.Location = new System.Drawing.Point(25, 318);
            this.gb_Clase.Name = "gb_Clase";
            this.gb_Clase.Size = new System.Drawing.Size(134, 100);
            this.gb_Clase.TabIndex = 0;
            this.gb_Clase.TabStop = false;
            this.gb_Clase.Text = "Clase";
            // 
            // rb_ClasePremium
            // 
            this.rb_ClasePremium.AutoSize = true;
            this.rb_ClasePremium.Location = new System.Drawing.Point(16, 52);
            this.rb_ClasePremium.Name = "rb_ClasePremium";
            this.rb_ClasePremium.Size = new System.Drawing.Size(74, 19);
            this.rb_ClasePremium.TabIndex = 1;
            this.rb_ClasePremium.TabStop = true;
            this.rb_ClasePremium.Text = "Premium";
            this.rb_ClasePremium.UseVisualStyleBackColor = true;
            this.rb_ClasePremium.CheckedChanged += new System.EventHandler(this.rb_ClasePremium_CheckedChanged);
            // 
            // rb_ClaseTurista
            // 
            this.rb_ClaseTurista.AutoSize = true;
            this.rb_ClaseTurista.Location = new System.Drawing.Point(16, 27);
            this.rb_ClaseTurista.Name = "rb_ClaseTurista";
            this.rb_ClaseTurista.Size = new System.Drawing.Size(60, 19);
            this.rb_ClaseTurista.TabIndex = 0;
            this.rb_ClaseTurista.TabStop = true;
            this.rb_ClaseTurista.Text = "Turista";
            this.rb_ClaseTurista.UseVisualStyleBackColor = true;
            this.rb_ClaseTurista.CheckedChanged += new System.EventHandler(this.rb_ClaseTurista_CheckedChanged);
            // 
            // dtg_DatosAMostrar
            // 
            this.dtg_DatosAMostrar.AllowUserToOrderColumns = true;
            this.dtg_DatosAMostrar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dtg_DatosAMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DatosAMostrar.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtg_DatosAMostrar.Location = new System.Drawing.Point(25, 23);
            this.dtg_DatosAMostrar.Name = "dtg_DatosAMostrar";
            this.dtg_DatosAMostrar.RowTemplate.Height = 25;
            this.dtg_DatosAMostrar.Size = new System.Drawing.Size(885, 150);
            this.dtg_DatosAMostrar.TabIndex = 1;
            this.dtg_DatosAMostrar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DatosAMostrar_CellClick);
            // 
            // txb_NombreCliente
            // 
            this.txb_NombreCliente.Location = new System.Drawing.Point(151, 202);
            this.txb_NombreCliente.Name = "txb_NombreCliente";
            this.txb_NombreCliente.Size = new System.Drawing.Size(100, 23);
            this.txb_NombreCliente.TabIndex = 2;
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_BuscarCliente.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarCliente.Location = new System.Drawing.Point(25, 196);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(104, 29);
            this.btn_BuscarCliente.TabIndex = 3;
            this.btn_BuscarCliente.Text = "Buscar Cliente";
            this.btn_BuscarCliente.UseVisualStyleBackColor = false;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // btn_BuscarVuelo
            // 
            this.btn_BuscarVuelo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_BuscarVuelo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarVuelo.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarVuelo.Location = new System.Drawing.Point(26, 237);
            this.btn_BuscarVuelo.Name = "btn_BuscarVuelo";
            this.btn_BuscarVuelo.Size = new System.Drawing.Size(104, 31);
            this.btn_BuscarVuelo.TabIndex = 4;
            this.btn_BuscarVuelo.Text = "Buscar Vuelo";
            this.btn_BuscarVuelo.UseVisualStyleBackColor = false;
            this.btn_BuscarVuelo.Click += new System.EventHandler(this.btn_BuscarVuelo_Click);
            // 
            // txb_IdVuelo
            // 
            this.txb_IdVuelo.Location = new System.Drawing.Point(151, 245);
            this.txb_IdVuelo.Name = "txb_IdVuelo";
            this.txb_IdVuelo.Size = new System.Drawing.Size(100, 23);
            this.txb_IdVuelo.TabIndex = 5;
            // 
            // gb_EquipajeDeMano
            // 
            this.gb_EquipajeDeMano.BackColor = System.Drawing.Color.SlateBlue;
            this.gb_EquipajeDeMano.Controls.Add(this.rb_NoLLevaBolsoDeMano);
            this.gb_EquipajeDeMano.Controls.Add(this.rb_LlevaBolsoDeMano);
            this.gb_EquipajeDeMano.Location = new System.Drawing.Point(30, 437);
            this.gb_EquipajeDeMano.Name = "gb_EquipajeDeMano";
            this.gb_EquipajeDeMano.Size = new System.Drawing.Size(129, 100);
            this.gb_EquipajeDeMano.TabIndex = 6;
            this.gb_EquipajeDeMano.TabStop = false;
            this.gb_EquipajeDeMano.Text = "Equipaje de mano";
            // 
            // rb_NoLLevaBolsoDeMano
            // 
            this.rb_NoLLevaBolsoDeMano.AutoSize = true;
            this.rb_NoLLevaBolsoDeMano.Location = new System.Drawing.Point(6, 52);
            this.rb_NoLLevaBolsoDeMano.Name = "rb_NoLLevaBolsoDeMano";
            this.rb_NoLLevaBolsoDeMano.Size = new System.Drawing.Size(41, 19);
            this.rb_NoLLevaBolsoDeMano.TabIndex = 1;
            this.rb_NoLLevaBolsoDeMano.TabStop = true;
            this.rb_NoLLevaBolsoDeMano.Text = "No";
            this.rb_NoLLevaBolsoDeMano.UseVisualStyleBackColor = true;
            // 
            // rb_LlevaBolsoDeMano
            // 
            this.rb_LlevaBolsoDeMano.AutoSize = true;
            this.rb_LlevaBolsoDeMano.Location = new System.Drawing.Point(6, 27);
            this.rb_LlevaBolsoDeMano.Name = "rb_LlevaBolsoDeMano";
            this.rb_LlevaBolsoDeMano.Size = new System.Drawing.Size(34, 19);
            this.rb_LlevaBolsoDeMano.TabIndex = 0;
            this.rb_LlevaBolsoDeMano.TabStop = true;
            this.rb_LlevaBolsoDeMano.Text = "Si";
            this.rb_LlevaBolsoDeMano.UseVisualStyleBackColor = true;
            // 
            // dtg_DatosAMostrar2
            // 
            this.dtg_DatosAMostrar2.AllowUserToOrderColumns = true;
            this.dtg_DatosAMostrar2.BackgroundColor = System.Drawing.Color.White;
            this.dtg_DatosAMostrar2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_DatosAMostrar2.Location = new System.Drawing.Point(268, 179);
            this.dtg_DatosAMostrar2.Name = "dtg_DatosAMostrar2";
            this.dtg_DatosAMostrar2.RowTemplate.Height = 25;
            this.dtg_DatosAMostrar2.Size = new System.Drawing.Size(642, 89);
            this.dtg_DatosAMostrar2.TabIndex = 7;
            this.dtg_DatosAMostrar2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_DatosAMostrar2_CellClick);
            // 
            // gb_Extras
            // 
            this.gb_Extras.BackColor = System.Drawing.Color.SlateBlue;
            this.gb_Extras.Controls.Add(this.chb_Peliculas);
            this.gb_Extras.Controls.Add(this.chb_Comida);
            this.gb_Extras.Controls.Add(this.chb_Wifi);
            this.gb_Extras.Location = new System.Drawing.Point(171, 318);
            this.gb_Extras.Name = "gb_Extras";
            this.gb_Extras.Size = new System.Drawing.Size(219, 100);
            this.gb_Extras.TabIndex = 9;
            this.gb_Extras.TabStop = false;
            this.gb_Extras.Text = "Extras";
            // 
            // chb_Peliculas
            // 
            this.chb_Peliculas.AutoSize = true;
            this.chb_Peliculas.Location = new System.Drawing.Point(6, 72);
            this.chb_Peliculas.Name = "chb_Peliculas";
            this.chb_Peliculas.Size = new System.Drawing.Size(72, 19);
            this.chb_Peliculas.TabIndex = 2;
            this.chb_Peliculas.Text = "Peliculas";
            this.chb_Peliculas.UseVisualStyleBackColor = true;
            // 
            // chb_Comida
            // 
            this.chb_Comida.AutoSize = true;
            this.chb_Comida.Location = new System.Drawing.Point(6, 47);
            this.chb_Comida.Name = "chb_Comida";
            this.chb_Comida.Size = new System.Drawing.Size(68, 19);
            this.chb_Comida.TabIndex = 1;
            this.chb_Comida.Text = "Comida";
            this.chb_Comida.UseVisualStyleBackColor = true;
            // 
            // chb_Wifi
            // 
            this.chb_Wifi.AutoSize = true;
            this.chb_Wifi.Location = new System.Drawing.Point(6, 22);
            this.chb_Wifi.Name = "chb_Wifi";
            this.chb_Wifi.Size = new System.Drawing.Size(47, 19);
            this.chb_Wifi.TabIndex = 0;
            this.chb_Wifi.Text = "Wifi";
            this.chb_Wifi.UseVisualStyleBackColor = true;
            // 
            // btn_CalcularPrecio
            // 
            this.btn_CalcularPrecio.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_CalcularPrecio.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CalcularPrecio.ForeColor = System.Drawing.Color.White;
            this.btn_CalcularPrecio.Location = new System.Drawing.Point(432, 286);
            this.btn_CalcularPrecio.Name = "btn_CalcularPrecio";
            this.btn_CalcularPrecio.Size = new System.Drawing.Size(200, 29);
            this.btn_CalcularPrecio.TabIndex = 11;
            this.btn_CalcularPrecio.Text = "Calcular precio";
            this.btn_CalcularPrecio.UseVisualStyleBackColor = false;
            this.btn_CalcularPrecio.Click += new System.EventHandler(this.btn_CalcularPrecio_Click);
            // 
            // lbl_PrecioBruto
            // 
            this.lbl_PrecioBruto.AutoSize = true;
            this.lbl_PrecioBruto.BackColor = System.Drawing.Color.White;
            this.lbl_PrecioBruto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PrecioBruto.ForeColor = System.Drawing.Color.Black;
            this.lbl_PrecioBruto.Location = new System.Drawing.Point(6, 60);
            this.lbl_PrecioBruto.Name = "lbl_PrecioBruto";
            this.lbl_PrecioBruto.Size = new System.Drawing.Size(16, 25);
            this.lbl_PrecioBruto.TabIndex = 12;
            this.lbl_PrecioBruto.Text = ".";
            // 
            // btn_FinalizarOperacion
            // 
            this.btn_FinalizarOperacion.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_FinalizarOperacion.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_FinalizarOperacion.ForeColor = System.Drawing.Color.White;
            this.btn_FinalizarOperacion.Location = new System.Drawing.Point(649, 286);
            this.btn_FinalizarOperacion.Name = "btn_FinalizarOperacion";
            this.btn_FinalizarOperacion.Size = new System.Drawing.Size(132, 29);
            this.btn_FinalizarOperacion.TabIndex = 13;
            this.btn_FinalizarOperacion.Text = "Finalizar Operacion";
            this.btn_FinalizarOperacion.UseVisualStyleBackColor = false;
            this.btn_FinalizarOperacion.Click += new System.EventHandler(this.btn_FinalizarOperacion_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(835, 624);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 29);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // gb_Bodega
            // 
            this.gb_Bodega.BackColor = System.Drawing.Color.SlateBlue;
            this.gb_Bodega.Controls.Add(this.label2);
            this.gb_Bodega.Controls.Add(this.label1);
            this.gb_Bodega.Controls.Add(this.txb_PesoValija2);
            this.gb_Bodega.Controls.Add(this.txb_PesoValija1);
            this.gb_Bodega.Location = new System.Drawing.Point(171, 437);
            this.gb_Bodega.Name = "gb_Bodega";
            this.gb_Bodega.Size = new System.Drawing.Size(219, 100);
            this.gb_Bodega.TabIndex = 15;
            this.gb_Bodega.TabStop = false;
            this.gb_Bodega.Text = "Equipaje Bodega";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Peso Valija dos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Peso Valija uno";
            // 
            // txb_PesoValija2
            // 
            this.txb_PesoValija2.Location = new System.Drawing.Point(128, 49);
            this.txb_PesoValija2.Name = "txb_PesoValija2";
            this.txb_PesoValija2.Size = new System.Drawing.Size(77, 23);
            this.txb_PesoValija2.TabIndex = 3;
            // 
            // txb_PesoValija1
            // 
            this.txb_PesoValija1.Location = new System.Drawing.Point(128, 24);
            this.txb_PesoValija1.Name = "txb_PesoValija1";
            this.txb_PesoValija1.Size = new System.Drawing.Size(77, 23);
            this.txb_PesoValija1.TabIndex = 2;
            // 
            // lbl_TextoPrecioBruto
            // 
            this.lbl_TextoPrecioBruto.AutoSize = true;
            this.lbl_TextoPrecioBruto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_TextoPrecioBruto.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TextoPrecioBruto.Location = new System.Drawing.Point(6, 19);
            this.lbl_TextoPrecioBruto.Name = "lbl_TextoPrecioBruto";
            this.lbl_TextoPrecioBruto.Size = new System.Drawing.Size(16, 25);
            this.lbl_TextoPrecioBruto.TabIndex = 16;
            this.lbl_TextoPrecioBruto.Text = ".";
            // 
            // lbl_TextoPrecioNeto
            // 
            this.lbl_TextoPrecioNeto.AutoSize = true;
            this.lbl_TextoPrecioNeto.BackColor = System.Drawing.Color.White;
            this.lbl_TextoPrecioNeto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TextoPrecioNeto.Location = new System.Drawing.Point(6, 19);
            this.lbl_TextoPrecioNeto.Name = "lbl_TextoPrecioNeto";
            this.lbl_TextoPrecioNeto.Size = new System.Drawing.Size(12, 20);
            this.lbl_TextoPrecioNeto.TabIndex = 17;
            this.lbl_TextoPrecioNeto.Text = ".";
            // 
            // lbl_PrecioNeto
            // 
            this.lbl_PrecioNeto.AutoSize = true;
            this.lbl_PrecioNeto.BackColor = System.Drawing.Color.White;
            this.lbl_PrecioNeto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_PrecioNeto.Location = new System.Drawing.Point(6, 59);
            this.lbl_PrecioNeto.Name = "lbl_PrecioNeto";
            this.lbl_PrecioNeto.Size = new System.Drawing.Size(12, 20);
            this.lbl_PrecioNeto.TabIndex = 18;
            this.lbl_PrecioNeto.Text = ".";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lbl_TextoPrecioBruto);
            this.groupBox1.Controls.Add(this.lbl_PrecioBruto);
            this.groupBox1.Location = new System.Drawing.Point(432, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbl_PrecioNeto);
            this.groupBox2.Controls.Add(this.lbl_TextoPrecioNeto);
            this.groupBox2.Location = new System.Drawing.Point(432, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // lbl_ConfirmacionPasajero
            // 
            this.lbl_ConfirmacionPasajero.AutoSize = true;
            this.lbl_ConfirmacionPasajero.Location = new System.Drawing.Point(483, 522);
            this.lbl_ConfirmacionPasajero.Name = "lbl_ConfirmacionPasajero";
            this.lbl_ConfirmacionPasajero.Size = new System.Drawing.Size(10, 15);
            this.lbl_ConfirmacionPasajero.TabIndex = 10;
            this.lbl_ConfirmacionPasajero.Text = ".";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Error.Location = new System.Drawing.Point(328, 624);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(10, 15);
            this.lbl_Error.TabIndex = 21;
            this.lbl_Error.Text = ".";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(835, 321);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 30);
            this.btn_Ayuda.TabIndex = 22;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // gb_Ayuda
            // 
            this.gb_Ayuda.BackColor = System.Drawing.Color.White;
            this.gb_Ayuda.Controls.Add(this.lbl_Ayuda);
            this.gb_Ayuda.Location = new System.Drawing.Point(649, 357);
            this.gb_Ayuda.Name = "gb_Ayuda";
            this.gb_Ayuda.Size = new System.Drawing.Size(261, 228);
            this.gb_Ayuda.TabIndex = 23;
            this.gb_Ayuda.TabStop = false;
            // 
            // lbl_Ayuda
            // 
            this.lbl_Ayuda.AutoSize = true;
            this.lbl_Ayuda.Location = new System.Drawing.Point(7, 28);
            this.lbl_Ayuda.Name = "lbl_Ayuda";
            this.lbl_Ayuda.Size = new System.Drawing.Size(0, 15);
            this.lbl_Ayuda.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.rb_CantPasajes4);
            this.groupBox3.Controls.Add(this.rb_CantPasajes3);
            this.groupBox3.Controls.Add(this.rb_CantPasajes2);
            this.groupBox3.Controls.Add(this.rb_CantPasajes1);
            this.groupBox3.Location = new System.Drawing.Point(32, 543);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(176, 110);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cantidad De Pasajes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = " Familiar)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Descuento";
            // 
            // rb_CantPasajes4
            // 
            this.rb_CantPasajes4.AutoSize = true;
            this.rb_CantPasajes4.Location = new System.Drawing.Point(67, 52);
            this.rb_CantPasajes4.Name = "rb_CantPasajes4";
            this.rb_CantPasajes4.Size = new System.Drawing.Size(31, 19);
            this.rb_CantPasajes4.TabIndex = 3;
            this.rb_CantPasajes4.TabStop = true;
            this.rb_CantPasajes4.Text = "4";
            this.rb_CantPasajes4.UseVisualStyleBackColor = true;
            // 
            // rb_CantPasajes3
            // 
            this.rb_CantPasajes3.AutoSize = true;
            this.rb_CantPasajes3.Location = new System.Drawing.Point(66, 27);
            this.rb_CantPasajes3.Name = "rb_CantPasajes3";
            this.rb_CantPasajes3.Size = new System.Drawing.Size(31, 19);
            this.rb_CantPasajes3.TabIndex = 2;
            this.rb_CantPasajes3.TabStop = true;
            this.rb_CantPasajes3.Text = "3";
            this.rb_CantPasajes3.UseVisualStyleBackColor = true;
            // 
            // rb_CantPasajes2
            // 
            this.rb_CantPasajes2.AutoSize = true;
            this.rb_CantPasajes2.Location = new System.Drawing.Point(12, 52);
            this.rb_CantPasajes2.Name = "rb_CantPasajes2";
            this.rb_CantPasajes2.Size = new System.Drawing.Size(31, 19);
            this.rb_CantPasajes2.TabIndex = 1;
            this.rb_CantPasajes2.TabStop = true;
            this.rb_CantPasajes2.Text = "2";
            this.rb_CantPasajes2.UseVisualStyleBackColor = true;
            // 
            // rb_CantPasajes1
            // 
            this.rb_CantPasajes1.AutoSize = true;
            this.rb_CantPasajes1.Location = new System.Drawing.Point(12, 27);
            this.rb_CantPasajes1.Name = "rb_CantPasajes1";
            this.rb_CantPasajes1.Size = new System.Drawing.Size(31, 19);
            this.rb_CantPasajes1.TabIndex = 0;
            this.rb_CantPasajes1.TabStop = true;
            this.rb_CantPasajes1.Text = "1";
            this.rb_CantPasajes1.UseVisualStyleBackColor = true;
            // 
            // AltaPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(922, 665);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gb_Ayuda);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Bodega);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_FinalizarOperacion);
            this.Controls.Add(this.btn_CalcularPrecio);
            this.Controls.Add(this.lbl_ConfirmacionPasajero);
            this.Controls.Add(this.gb_Extras);
            this.Controls.Add(this.dtg_DatosAMostrar2);
            this.Controls.Add(this.gb_Clase);
            this.Controls.Add(this.gb_EquipajeDeMano);
            this.Controls.Add(this.txb_IdVuelo);
            this.Controls.Add(this.btn_BuscarVuelo);
            this.Controls.Add(this.btn_BuscarCliente);
            this.Controls.Add(this.txb_NombreCliente);
            this.Controls.Add(this.dtg_DatosAMostrar);
            this.DoubleBuffered = true;
            this.Name = "AltaPasajero";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AltaPasajero_Load);
            this.gb_Clase.ResumeLayout(false);
            this.gb_Clase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DatosAMostrar)).EndInit();
            this.gb_EquipajeDeMano.ResumeLayout(false);
            this.gb_EquipajeDeMano.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_DatosAMostrar2)).EndInit();
            this.gb_Extras.ResumeLayout(false);
            this.gb_Extras.PerformLayout();
            this.gb_Bodega.ResumeLayout(false);
            this.gb_Bodega.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_Ayuda.ResumeLayout(false);
            this.gb_Ayuda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Clase;
        private System.Windows.Forms.RadioButton rb_ClasePremium;
        private System.Windows.Forms.RadioButton rb_ClaseTurista;
        private System.Windows.Forms.DataGridView dtg_DatosAMostrar;
        private System.Windows.Forms.TextBox txb_NombreCliente;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.Button btn_BuscarVuelo;
        private System.Windows.Forms.TextBox txb_IdVuelo;
        private System.Windows.Forms.GroupBox gb_EquipajeDeMano;
        private System.Windows.Forms.RadioButton rb_NoLLevaBolsoDeMano;
        private System.Windows.Forms.RadioButton rb_LlevaBolsoDeMano;
        private System.Windows.Forms.DataGridView dtg_DatosAMostrar2;
        private System.Windows.Forms.GroupBox gb_Extras;
        private System.Windows.Forms.CheckBox chb_Peliculas;
        private System.Windows.Forms.CheckBox chb_Comida;
        private System.Windows.Forms.CheckBox chb_Wifi;
        private System.Windows.Forms.Button btn_CalcularPrecio;
        private System.Windows.Forms.Label lbl_PrecioBruto;
        private System.Windows.Forms.Button btn_FinalizarOperacion;
        private System.Windows.Forms.Button btn_Salir;
        protected System.Windows.Forms.GroupBox gb_Bodega;
        private System.Windows.Forms.TextBox txb_PesoValija2;
        private System.Windows.Forms.TextBox txb_PesoValija1;
        private System.Windows.Forms.Label lbl_TextoPrecioBruto;
        private System.Windows.Forms.Label lbl_TextoPrecioNeto;
        private System.Windows.Forms.Label lbl_PrecioNeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_ConfirmacionPasajero;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.GroupBox gb_Ayuda;
        private System.Windows.Forms.Label lbl_Ayuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_CantPasajes4;
        private System.Windows.Forms.RadioButton rb_CantPasajes3;
        private System.Windows.Forms.RadioButton rb_CantPasajes2;
        private System.Windows.Forms.RadioButton rb_CantPasajes1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}