namespace UI
{
    partial class ModificarCliente
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
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txb_Dni = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_Apellido = new System.Windows.Forms.TextBox();
            this.txb_Edad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.dtg_Datos.GridColor = System.Drawing.Color.White;
            this.dtg_Datos.Location = new System.Drawing.Point(12, 12);
            this.dtg_Datos.Name = "dtg_Datos";
            this.dtg_Datos.RowTemplate.Height = 25;
            this.dtg_Datos.Size = new System.Drawing.Size(516, 150);
            this.dtg_Datos.TabIndex = 0;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Buscar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Buscar.Location = new System.Drawing.Point(404, 164);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(124, 28);
            this.btn_Buscar.TabIndex = 1;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txb_Dni
            // 
            this.txb_Dni.Location = new System.Drawing.Point(416, 206);
            this.txb_Dni.Name = "txb_Dni";
            this.txb_Dni.PlaceholderText = "DNI";
            this.txb_Dni.Size = new System.Drawing.Size(100, 23);
            this.txb_Dni.TabIndex = 2;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Eliminar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.Location = new System.Drawing.Point(257, 164);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(124, 28);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Modificar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(13, 164);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(229, 28);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "MODIFICAR";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Confirmar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.Location = new System.Drawing.Point(76, 320);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(100, 23);
            this.btn_Confirmar.TabIndex = 6;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(453, 352);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(89, 211);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.PlaceholderText = "NOMBRE";
            this.txb_Nombre.Size = new System.Drawing.Size(153, 23);
            this.txb_Nombre.TabIndex = 9;
            // 
            // txb_Apellido
            // 
            this.txb_Apellido.Location = new System.Drawing.Point(89, 252);
            this.txb_Apellido.Name = "txb_Apellido";
            this.txb_Apellido.PlaceholderText = "APELLIDO";
            this.txb_Apellido.Size = new System.Drawing.Size(153, 23);
            this.txb_Apellido.TabIndex = 10;
            // 
            // txb_Edad
            // 
            this.txb_Edad.Location = new System.Drawing.Point(89, 291);
            this.txb_Edad.Name = "txb_Edad";
            this.txb_Edad.PlaceholderText = "EDAD";
            this.txb_Edad.Size = new System.Drawing.Size(153, 23);
            this.txb_Edad.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Edad";
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Location = new System.Drawing.Point(12, 362);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(10, 15);
            this.lbl_Error.TabIndex = 15;
            this.lbl_Error.Text = ".";
            // 
            // btn_VerLista
            // 
            this.btn_VerLista.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_VerLista.Location = new System.Drawing.Point(404, 247);
            this.btn_VerLista.Name = "btn_VerLista";
            this.btn_VerLista.Size = new System.Drawing.Size(124, 23);
            this.btn_VerLista.TabIndex = 16;
            this.btn_VerLista.Text = "VER CLIENTES";
            this.btn_VerLista.UseVisualStyleBackColor = false;
            this.btn_VerLista.Click += new System.EventHandler(this.btn_VerLista_Click);
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(540, 387);
            this.Controls.Add(this.btn_VerLista);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Edad);
            this.Controls.Add(this.txb_Apellido);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txb_Dni);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dtg_Datos);
            this.Name = "ModificarCliente";
            this.Text = "ModificarCliente";
            this.Load += new System.EventHandler(this.ModificarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Datos;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txb_Dni;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txb_Apellido;
        private System.Windows.Forms.TextBox txb_Edad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.Button btn_VerLista;
    }
}