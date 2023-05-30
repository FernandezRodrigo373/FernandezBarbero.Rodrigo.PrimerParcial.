namespace UI
{
    partial class ModificarAvion
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
            this.dtg_Datos = new System.Windows.Forms.DataGridView();
            this.btn_BuscaAvion = new System.Windows.Forms.Button();
            this.txb_AvionID = new System.Windows.Forms.TextBox();
            this.btn_EliminarAvion = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_CrearAvion = new System.Windows.Forms.Button();
            this.txb_Matricula = new System.Windows.Forms.TextBox();
            this.txb_CantidadDeAsientos = new System.Windows.Forms.TextBox();
            this.txb_CantBanios = new System.Windows.Forms.TextBox();
            this.txb_CapacidadBodega = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.lbl_CantidadDeAviones = new System.Windows.Forms.Label();
            this.txb_ModificaBodega = new System.Windows.Forms.TextBox();
            this.txb_ModificaBanios = new System.Windows.Forms.TextBox();
            this.txb_ModificaAsientos = new System.Windows.Forms.TextBox();
            this.txb_ModificaMatricula = new System.Windows.Forms.TextBox();
            this.btn_ConfrimarModifica = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.btn_VerLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Datos
            // 
            this.dtg_Datos.AllowUserToOrderColumns = true;
            this.dtg_Datos.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dtg_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Datos.Location = new System.Drawing.Point(12, 12);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(449, 150);
            this.dtg_Datos.TabIndex = 0;
            // 
            // btn_BuscaAvion
            // 
            this.btn_BuscaAvion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_BuscaAvion.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscaAvion.Location = new System.Drawing.Point(12, 170);
            this.btn_BuscaAvion.Name = "btn_BuscaAvion";
            this.btn_BuscaAvion.Size = new System.Drawing.Size(138, 49);
            this.btn_BuscaAvion.TabIndex = 1;
            this.btn_BuscaAvion.Text = "BUSCAR AVION POR MATRICULA";
            this.btn_BuscaAvion.UseVisualStyleBackColor = false;
            this.btn_BuscaAvion.Click += new System.EventHandler(this.btn_BuscaAvion_Click);
            // 
            // txb_AvionID
            // 
            this.txb_AvionID.Location = new System.Drawing.Point(31, 225);
            this.txb_AvionID.Name = "txb_AvionID";
            this.txb_AvionID.Size = new System.Drawing.Size(100, 23);
            this.txb_AvionID.TabIndex = 2;
            // 
            // btn_EliminarAvion
            // 
            this.btn_EliminarAvion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_EliminarAvion.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EliminarAvion.Location = new System.Drawing.Point(31, 263);
            this.btn_EliminarAvion.Name = "btn_EliminarAvion";
            this.btn_EliminarAvion.Size = new System.Drawing.Size(100, 23);
            this.btn_EliminarAvion.TabIndex = 3;
            this.btn_EliminarAvion.Text = "ELIMINAR";
            this.btn_EliminarAvion.UseVisualStyleBackColor = false;
            this.btn_EliminarAvion.Click += new System.EventHandler(this.btn_EliminarAvion_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Modificar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(188, 180);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(119, 39);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_CrearAvion
            // 
            this.btn_CrearAvion.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_CrearAvion.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CrearAvion.Location = new System.Drawing.Point(342, 180);
            this.btn_CrearAvion.Name = "btn_CrearAvion";
            this.btn_CrearAvion.Size = new System.Drawing.Size(119, 39);
            this.btn_CrearAvion.TabIndex = 5;
            this.btn_CrearAvion.Text = "AÑADIR AVION ";
            this.btn_CrearAvion.UseVisualStyleBackColor = false;
            this.btn_CrearAvion.Click += new System.EventHandler(this.btn_CrearAvion_Click);
            // 
            // txb_Matricula
            // 
            this.txb_Matricula.Location = new System.Drawing.Point(342, 225);
            this.txb_Matricula.Name = "txb_Matricula";
            this.txb_Matricula.PlaceholderText = "Matricula";
            this.txb_Matricula.Size = new System.Drawing.Size(119, 23);
            this.txb_Matricula.TabIndex = 6;
            // 
            // txb_CantidadDeAsientos
            // 
            this.txb_CantidadDeAsientos.Location = new System.Drawing.Point(342, 254);
            this.txb_CantidadDeAsientos.Name = "txb_CantidadDeAsientos";
            this.txb_CantidadDeAsientos.PlaceholderText = "Cantidad de asientos";
            this.txb_CantidadDeAsientos.Size = new System.Drawing.Size(119, 23);
            this.txb_CantidadDeAsientos.TabIndex = 7;
            // 
            // txb_CantBanios
            // 
            this.txb_CantBanios.Location = new System.Drawing.Point(342, 283);
            this.txb_CantBanios.Name = "txb_CantBanios";
            this.txb_CantBanios.PlaceholderText = "Cantidad de baños";
            this.txb_CantBanios.Size = new System.Drawing.Size(119, 23);
            this.txb_CantBanios.TabIndex = 8;
            // 
            // txb_CapacidadBodega
            // 
            this.txb_CapacidadBodega.Location = new System.Drawing.Point(342, 312);
            this.txb_CapacidadBodega.Name = "txb_CapacidadBodega";
            this.txb_CapacidadBodega.PlaceholderText = "Capacidad Bodega";
            this.txb_CapacidadBodega.Size = new System.Drawing.Size(119, 23);
            this.txb_CapacidadBodega.TabIndex = 9;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(396, 381);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 11;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Confirmar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.Location = new System.Drawing.Point(355, 341);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(87, 23);
            this.btn_Confirmar.TabIndex = 12;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // lbl_CantidadDeAviones
            // 
            this.lbl_CantidadDeAviones.AutoSize = true;
            this.lbl_CantidadDeAviones.Location = new System.Drawing.Point(12, 385);
            this.lbl_CantidadDeAviones.Name = "lbl_CantidadDeAviones";
            this.lbl_CantidadDeAviones.Size = new System.Drawing.Size(10, 15);
            this.lbl_CantidadDeAviones.TabIndex = 13;
            this.lbl_CantidadDeAviones.Text = ".";
            // 
            // txb_ModificaBodega
            // 
            this.txb_ModificaBodega.Location = new System.Drawing.Point(188, 312);
            this.txb_ModificaBodega.Name = "txb_ModificaBodega";
            this.txb_ModificaBodega.PlaceholderText = "Capacidad Bodega";
            this.txb_ModificaBodega.Size = new System.Drawing.Size(119, 23);
            this.txb_ModificaBodega.TabIndex = 17;
            // 
            // txb_ModificaBanios
            // 
            this.txb_ModificaBanios.Location = new System.Drawing.Point(188, 283);
            this.txb_ModificaBanios.Name = "txb_ModificaBanios";
            this.txb_ModificaBanios.PlaceholderText = "Cantidad de baños";
            this.txb_ModificaBanios.Size = new System.Drawing.Size(119, 23);
            this.txb_ModificaBanios.TabIndex = 16;
            // 
            // txb_ModificaAsientos
            // 
            this.txb_ModificaAsientos.Location = new System.Drawing.Point(188, 254);
            this.txb_ModificaAsientos.Name = "txb_ModificaAsientos";
            this.txb_ModificaAsientos.PlaceholderText = "Cantidad de asientos";
            this.txb_ModificaAsientos.Size = new System.Drawing.Size(119, 23);
            this.txb_ModificaAsientos.TabIndex = 15;
            // 
            // txb_ModificaMatricula
            // 
            this.txb_ModificaMatricula.Location = new System.Drawing.Point(188, 225);
            this.txb_ModificaMatricula.Name = "txb_ModificaMatricula";
            this.txb_ModificaMatricula.PlaceholderText = "Matricula";
            this.txb_ModificaMatricula.Size = new System.Drawing.Size(119, 23);
            this.txb_ModificaMatricula.TabIndex = 14;
            // 
            // btn_ConfrimarModifica
            // 
            this.btn_ConfrimarModifica.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_ConfrimarModifica.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ConfrimarModifica.Location = new System.Drawing.Point(204, 341);
            this.btn_ConfrimarModifica.Name = "btn_ConfrimarModifica";
            this.btn_ConfrimarModifica.Size = new System.Drawing.Size(87, 23);
            this.btn_ConfrimarModifica.TabIndex = 18;
            this.btn_ConfrimarModifica.Text = "CONFIRMAR";
            this.btn_ConfrimarModifica.UseVisualStyleBackColor = false;
            this.btn_ConfrimarModifica.Click += new System.EventHandler(this.btn_ConfrimarModifica_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(12, 370);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(10, 15);
            this.lbl_Error.TabIndex = 19;
            this.lbl_Error.Text = ".";
            // 
            // btn_VerLista
            // 
            this.btn_VerLista.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_VerLista.Location = new System.Drawing.Point(30, 323);
            this.btn_VerLista.Name = "btn_VerLista";
            this.btn_VerLista.Size = new System.Drawing.Size(120, 23);
            this.btn_VerLista.TabIndex = 20;
            this.btn_VerLista.Text = "Ver lista";
            this.btn_VerLista.UseVisualStyleBackColor = false;
            this.btn_VerLista.Click += new System.EventHandler(this.btn_VerLista_Click);
            // 
            // ModificarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(483, 416);
            this.ControlBox = false;
            this.Controls.Add(this.btn_VerLista);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_ConfrimarModifica);
            this.Controls.Add(this.txb_ModificaBodega);
            this.Controls.Add(this.txb_ModificaBanios);
            this.Controls.Add(this.txb_ModificaAsientos);
            this.Controls.Add(this.txb_ModificaMatricula);
            this.Controls.Add(this.lbl_CantidadDeAviones);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txb_CapacidadBodega);
            this.Controls.Add(this.txb_CantBanios);
            this.Controls.Add(this.txb_CantidadDeAsientos);
            this.Controls.Add(this.txb_Matricula);
            this.Controls.Add(this.btn_CrearAvion);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_EliminarAvion);
            this.Controls.Add(this.txb_AvionID);
            this.Controls.Add(this.btn_BuscaAvion);
            this.Controls.Add(this.dtg_Datos);
            this.Name = "ModificarAvion";
            this.Text = "ModificarAvion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ModificarAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.Button btn_BuscaAvion;
        private System.Windows.Forms.TextBox txb_AvionID;
        private System.Windows.Forms.Button btn_EliminarAvion;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_CrearAvion;
        private System.Windows.Forms.TextBox txb_Matricula;
        private System.Windows.Forms.TextBox txb_CantidadDeAsientos;
        private System.Windows.Forms.TextBox txb_CantBanios;
        private System.Windows.Forms.TextBox txb_CapacidadBodega;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Label lbl_CantidadDeAviones;
        private System.Windows.Forms.TextBox txb_ModificaBodega;
        private System.Windows.Forms.TextBox txb_ModificaBanios;
        private System.Windows.Forms.TextBox txb_ModificaAsientos;
        private System.Windows.Forms.TextBox txb_ModificaMatricula;
        private System.Windows.Forms.Button btn_ConfrimarModifica;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_VerLista;
    }
}