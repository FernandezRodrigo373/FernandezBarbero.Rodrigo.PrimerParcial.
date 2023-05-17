namespace UI
{
    partial class MenuAerolinea
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeAltaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inoformeAvionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAvionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_CrearVuelos = new System.Windows.Forms.Button();
            this.btn_VenderVuelos = new System.Windows.Forms.Button();
            this.btn_ListaDeVuelos = new System.Windows.Forms.Button();
            this.btn_BuscarVuelosPorId = new System.Windows.Forms.Button();
            this.btn_BuscarCliente = new System.Windows.Forms.Button();
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.txb_VueloABuscar = new System.Windows.Forms.TextBox();
            this.txb_ClienteABuscar = new System.Windows.Forms.TextBox();
            this.btn_RealizarSorteo = new System.Windows.Forms.Button();
            this.btn_ConsultarEstadisticas = new System.Windows.Forms.Button();
            this.lbl_OperadorTexto = new System.Windows.Forms.Label();
            this.lbl_Operador = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.gb_MuestraDatos = new System.Windows.Forms.GroupBox();
            this.lbl_Ayuda = new System.Windows.Forms.Label();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.dtg_Dato2 = new System.Windows.Forms.DataGridView();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            this.gb_MuestraDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Dato2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.avionToolStripMenuItem,
            this.vueloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 50);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.clientesToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.darDeAltaClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clientesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(70, 46);
            this.clientesToolStripMenuItem.Text = "CLIENTES";
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.listadoToolStripMenuItem.Text = "Listado de clientes";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // darDeAltaClienteToolStripMenuItem
            // 
            this.darDeAltaClienteToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.darDeAltaClienteToolStripMenuItem.Name = "darDeAltaClienteToolStripMenuItem";
            this.darDeAltaClienteToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.darDeAltaClienteToolStripMenuItem.Text = "Dar de Alta Cliente";
            this.darDeAltaClienteToolStripMenuItem.Click += new System.EventHandler(this.darDeAltaClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // avionToolStripMenuItem
            // 
            this.avionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inoformeAvionToolStripMenuItem,
            this.modificarAvionesToolStripMenuItem});
            this.avionToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.avionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.avionToolStripMenuItem.Name = "avionToolStripMenuItem";
            this.avionToolStripMenuItem.Size = new System.Drawing.Size(50, 46);
            this.avionToolStripMenuItem.Text = "AVION";
            // 
            // inoformeAvionToolStripMenuItem
            // 
            this.inoformeAvionToolStripMenuItem.Name = "inoformeAvionToolStripMenuItem";
            this.inoformeAvionToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.inoformeAvionToolStripMenuItem.Text = "Listado de Aviones";
            this.inoformeAvionToolStripMenuItem.Click += new System.EventHandler(this.inoformeAvionToolStripMenuItem_Click);
            // 
            // modificarAvionesToolStripMenuItem
            // 
            this.modificarAvionesToolStripMenuItem.Name = "modificarAvionesToolStripMenuItem";
            this.modificarAvionesToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.modificarAvionesToolStripMenuItem.Text = "Modificar aviones";
            this.modificarAvionesToolStripMenuItem.Click += new System.EventHandler(this.modificarAvionesToolStripMenuItem_Click);
            // 
            // vueloToolStripMenuItem
            // 
            this.vueloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarVueloToolStripMenuItem});
            this.vueloToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vueloToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vueloToolStripMenuItem.Name = "vueloToolStripMenuItem";
            this.vueloToolStripMenuItem.Size = new System.Drawing.Size(53, 46);
            this.vueloToolStripMenuItem.Text = "VUELO";
            // 
            // buscarVueloToolStripMenuItem
            // 
            this.buscarVueloToolStripMenuItem.Name = "buscarVueloToolStripMenuItem";
            this.buscarVueloToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.buscarVueloToolStripMenuItem.Text = "Buscar Vuelo";
            this.buscarVueloToolStripMenuItem.Click += new System.EventHandler(this.buscarVueloToolStripMenuItem_Click);
            // 
            // btn_CrearVuelos
            // 
            this.btn_CrearVuelos.BackColor = System.Drawing.Color.White;
            this.btn_CrearVuelos.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearVuelos.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_CrearVuelos.Location = new System.Drawing.Point(12, 102);
            this.btn_CrearVuelos.Name = "btn_CrearVuelos";
            this.btn_CrearVuelos.Size = new System.Drawing.Size(165, 32);
            this.btn_CrearVuelos.TabIndex = 13;
            this.btn_CrearVuelos.Text = "CREAR VUELO";
            this.btn_CrearVuelos.UseVisualStyleBackColor = false;
            this.btn_CrearVuelos.Click += new System.EventHandler(this.btn_CrearVuelos_Click);
            // 
            // btn_VenderVuelos
            // 
            this.btn_VenderVuelos.BackColor = System.Drawing.Color.White;
            this.btn_VenderVuelos.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_VenderVuelos.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_VenderVuelos.Location = new System.Drawing.Point(12, 63);
            this.btn_VenderVuelos.Name = "btn_VenderVuelos";
            this.btn_VenderVuelos.Size = new System.Drawing.Size(165, 33);
            this.btn_VenderVuelos.TabIndex = 12;
            this.btn_VenderVuelos.Text = "VENDER VUELO";
            this.btn_VenderVuelos.UseVisualStyleBackColor = false;
            this.btn_VenderVuelos.Click += new System.EventHandler(this.btn_VenderVuelos_Click);
            // 
            // btn_ListaDeVuelos
            // 
            this.btn_ListaDeVuelos.BackColor = System.Drawing.Color.White;
            this.btn_ListaDeVuelos.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ListaDeVuelos.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ListaDeVuelos.Location = new System.Drawing.Point(12, 140);
            this.btn_ListaDeVuelos.Name = "btn_ListaDeVuelos";
            this.btn_ListaDeVuelos.Size = new System.Drawing.Size(165, 32);
            this.btn_ListaDeVuelos.TabIndex = 11;
            this.btn_ListaDeVuelos.Text = "VISUALIZAR VUELOS";
            this.btn_ListaDeVuelos.UseVisualStyleBackColor = false;
            this.btn_ListaDeVuelos.Click += new System.EventHandler(this.btn_ListaDeVuelos_Click);
            // 
            // btn_BuscarVuelosPorId
            // 
            this.btn_BuscarVuelosPorId.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_BuscarVuelosPorId.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarVuelosPorId.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarVuelosPorId.Location = new System.Drawing.Point(36, 378);
            this.btn_BuscarVuelosPorId.Name = "btn_BuscarVuelosPorId";
            this.btn_BuscarVuelosPorId.Size = new System.Drawing.Size(286, 32);
            this.btn_BuscarVuelosPorId.TabIndex = 19;
            this.btn_BuscarVuelosPorId.Text = "BUSCAR VUELO POR ID ";
            this.btn_BuscarVuelosPorId.UseVisualStyleBackColor = false;
            this.btn_BuscarVuelosPorId.Click += new System.EventHandler(this.btn_BuscarVuelosPorId_Click);
            // 
            // btn_BuscarCliente
            // 
            this.btn_BuscarCliente.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_BuscarCliente.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_BuscarCliente.Location = new System.Drawing.Point(36, 334);
            this.btn_BuscarCliente.Name = "btn_BuscarCliente";
            this.btn_BuscarCliente.Size = new System.Drawing.Size(286, 38);
            this.btn_BuscarCliente.TabIndex = 18;
            this.btn_BuscarCliente.Text = "BUSCAR CLIENTE";
            this.btn_BuscarCliente.UseVisualStyleBackColor = false;
            this.btn_BuscarCliente.Click += new System.EventHandler(this.btn_BuscarCliente_Click);
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToOrderColumns = true;
            this.dtg_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtg_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg_Datos.BackgroundColor = System.Drawing.Color.White;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(12, 178);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(894, 150);
            this.dtg_Datos.TabIndex = 17;
            // 
            // txb_VueloABuscar
            // 
            this.txb_VueloABuscar.Location = new System.Drawing.Point(366, 387);
            this.txb_VueloABuscar.Name = "txb_VueloABuscar";
            this.txb_VueloABuscar.Size = new System.Drawing.Size(282, 23);
            this.txb_VueloABuscar.TabIndex = 21;
            // 
            // txb_ClienteABuscar
            // 
            this.txb_ClienteABuscar.BackColor = System.Drawing.Color.White;
            this.txb_ClienteABuscar.Location = new System.Drawing.Point(366, 346);
            this.txb_ClienteABuscar.Name = "txb_ClienteABuscar";
            this.txb_ClienteABuscar.Size = new System.Drawing.Size(283, 23);
            this.txb_ClienteABuscar.TabIndex = 20;
            // 
            // btn_RealizarSorteo
            // 
            this.btn_RealizarSorteo.BackColor = System.Drawing.Color.HotPink;
            this.btn_RealizarSorteo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_RealizarSorteo.ForeColor = System.Drawing.Color.White;
            this.btn_RealizarSorteo.Location = new System.Drawing.Point(198, 477);
            this.btn_RealizarSorteo.Name = "btn_RealizarSorteo";
            this.btn_RealizarSorteo.Size = new System.Drawing.Size(151, 35);
            this.btn_RealizarSorteo.TabIndex = 24;
            this.btn_RealizarSorteo.Text = "Realizar Sorteo";
            this.btn_RealizarSorteo.UseVisualStyleBackColor = false;
            this.btn_RealizarSorteo.Click += new System.EventHandler(this.btn_RealizarSorteo_Click);
            // 
            // btn_ConsultarEstadisticas
            // 
            this.btn_ConsultarEstadisticas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ConsultarEstadisticas.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ConsultarEstadisticas.ForeColor = System.Drawing.Color.White;
            this.btn_ConsultarEstadisticas.Location = new System.Drawing.Point(12, 474);
            this.btn_ConsultarEstadisticas.Name = "btn_ConsultarEstadisticas";
            this.btn_ConsultarEstadisticas.Size = new System.Drawing.Size(165, 38);
            this.btn_ConsultarEstadisticas.TabIndex = 23;
            this.btn_ConsultarEstadisticas.Text = "Consultar Estadisticas";
            this.btn_ConsultarEstadisticas.UseVisualStyleBackColor = false;
            this.btn_ConsultarEstadisticas.Click += new System.EventHandler(this.btn_ConsultarEstadisticas_Click);
            // 
            // lbl_OperadorTexto
            // 
            this.lbl_OperadorTexto.AutoSize = true;
            this.lbl_OperadorTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_OperadorTexto.ForeColor = System.Drawing.Color.White;
            this.lbl_OperadorTexto.Location = new System.Drawing.Point(834, 63);
            this.lbl_OperadorTexto.Name = "lbl_OperadorTexto";
            this.lbl_OperadorTexto.Size = new System.Drawing.Size(195, 21);
            this.lbl_OperadorTexto.TabIndex = 27;
            this.lbl_OperadorTexto.Text = "OPERADOR CONECTADO: ";
            // 
            // lbl_Operador
            // 
            this.lbl_Operador.AutoSize = true;
            this.lbl_Operador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Operador.ForeColor = System.Drawing.Color.White;
            this.lbl_Operador.Location = new System.Drawing.Point(1052, 63);
            this.lbl_Operador.Name = "lbl_Operador";
            this.lbl_Operador.Size = new System.Drawing.Size(13, 21);
            this.lbl_Operador.TabIndex = 26;
            this.lbl_Operador.Text = ".";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Fecha.Location = new System.Drawing.Point(834, 84);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(12, 19);
            this.lbl_Fecha.TabIndex = 25;
            this.lbl_Fecha.Text = ".";
            // 
            // gb_MuestraDatos
            // 
            this.gb_MuestraDatos.BackColor = System.Drawing.Color.White;
            this.gb_MuestraDatos.Controls.Add(this.lbl_Ayuda);
            this.gb_MuestraDatos.Location = new System.Drawing.Point(730, 346);
            this.gb_MuestraDatos.Name = "gb_MuestraDatos";
            this.gb_MuestraDatos.Size = new System.Drawing.Size(435, 157);
            this.gb_MuestraDatos.TabIndex = 30;
            this.gb_MuestraDatos.TabStop = false;
            this.gb_MuestraDatos.Text = ".";
            // 
            // lbl_Ayuda
            // 
            this.lbl_Ayuda.AutoSize = true;
            this.lbl_Ayuda.Location = new System.Drawing.Point(6, 31);
            this.lbl_Ayuda.Name = "lbl_Ayuda";
            this.lbl_Ayuda.Size = new System.Drawing.Size(10, 15);
            this.lbl_Ayuda.TabIndex = 24;
            this.lbl_Ayuda.Text = ".";
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(1217, 346);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ayuda.TabIndex = 29;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // dtg_Dato2
            // 
            this.dtg_Dato2.AllowUserToOrderColumns = true;
            this.dtg_Dato2.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtg_Dato2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Dato2.Location = new System.Drawing.Point(912, 178);
            this.dtg_Dato2.Name = "dtg_Dato2";
            this.dtg_Dato2.RowTemplate.Height = 25;
            this.dtg_Dato2.Size = new System.Drawing.Size(380, 150);
            this.dtg_Dato2.TabIndex = 28;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(1217, 474);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 28);
            this.btn_Salir.TabIndex = 31;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuAerolinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1307, 524);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gb_MuestraDatos);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.dtg_Dato2);
            this.Controls.Add(this.lbl_OperadorTexto);
            this.Controls.Add(this.lbl_Operador);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.btn_RealizarSorteo);
            this.Controls.Add(this.btn_ConsultarEstadisticas);
            this.Controls.Add(this.txb_VueloABuscar);
            this.Controls.Add(this.txb_ClienteABuscar);
            this.Controls.Add(this.btn_BuscarVuelosPorId);
            this.Controls.Add(this.btn_BuscarCliente);
            this.Controls.Add(this.dtg_Datos);
            this.Controls.Add(this.btn_CrearVuelos);
            this.Controls.Add(this.btn_VenderVuelos);
            this.Controls.Add(this.btn_ListaDeVuelos);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "MenuAerolinea";
            this.Text = "MenuAerolinea";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.gb_MuestraDatos.ResumeLayout(false);
            this.gb_MuestraDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Dato2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inoformeAvionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarVueloToolStripMenuItem;
        private System.Windows.Forms.Button btn_CrearVuelos;
        private System.Windows.Forms.Button btn_VenderVuelos;
        private System.Windows.Forms.Button btn_ListaDeVuelos;
        private System.Windows.Forms.Button btn_BuscarVuelosPorId;
        private System.Windows.Forms.Button btn_BuscarCliente;
        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.TextBox txb_VueloABuscar;
        private System.Windows.Forms.TextBox txb_ClienteABuscar;
        private System.Windows.Forms.Button btn_RealizarSorteo;
        private System.Windows.Forms.Button btn_ConsultarEstadisticas;
        private System.Windows.Forms.Label lbl_OperadorTexto;
        private System.Windows.Forms.Label lbl_Operador;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.GroupBox gb_MuestraDatos;
        private System.Windows.Forms.Label lbl_Ayuda;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.DataGridView dtg_Dato2;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem modificarAvionesToolStripMenuItem;
    }
}