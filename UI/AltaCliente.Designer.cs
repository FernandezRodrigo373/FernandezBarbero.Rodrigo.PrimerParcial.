namespace UI
{
    partial class AltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaCliente));
            this.txb_Dni = new System.Windows.Forms.TextBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_Apellido = new System.Windows.Forms.TextBox();
            this.txb_Edad = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.lbl_Ayuda = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.gb_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_Dni
            // 
            this.txb_Dni.Location = new System.Drawing.Point(47, 23);
            this.txb_Dni.Name = "txb_Dni";
            this.txb_Dni.PlaceholderText = "DNI";
            this.txb_Dni.Size = new System.Drawing.Size(228, 23);
            this.txb_Dni.TabIndex = 1;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(47, 66);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.PlaceholderText = "Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(228, 23);
            this.txb_Nombre.TabIndex = 2;
            // 
            // txb_Apellido
            // 
            this.txb_Apellido.Location = new System.Drawing.Point(47, 111);
            this.txb_Apellido.Name = "txb_Apellido";
            this.txb_Apellido.PlaceholderText = "Apellido";
            this.txb_Apellido.Size = new System.Drawing.Size(228, 23);
            this.txb_Apellido.TabIndex = 3;
            // 
            // txb_Edad
            // 
            this.txb_Edad.Location = new System.Drawing.Point(47, 155);
            this.txb_Edad.Name = "txb_Edad";
            this.txb_Edad.PlaceholderText = "Edad";
            this.txb_Edad.Size = new System.Drawing.Size(228, 23);
            this.txb_Edad.TabIndex = 4;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(263, 388);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 30);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Agregar.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.ForeColor = System.Drawing.Color.White;
            this.btn_Agregar.Location = new System.Drawing.Point(68, 208);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(187, 34);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.Location = new System.Drawing.Point(263, 275);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(75, 23);
            this.btn_Ayuda.TabIndex = 7;
            this.btn_Ayuda.Text = "Ayuda";
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            this.btn_Ayuda.Click += new System.EventHandler(this.btn_Ayuda_Click);
            // 
            // gb_Datos
            // 
            this.gb_Datos.BackColor = System.Drawing.Color.White;
            this.gb_Datos.Controls.Add(this.lbl_Ayuda);
            this.gb_Datos.Location = new System.Drawing.Point(9, 275);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(238, 116);
            this.gb_Datos.TabIndex = 8;
            this.gb_Datos.TabStop = false;
            // 
            // lbl_Ayuda
            // 
            this.lbl_Ayuda.AutoSize = true;
            this.lbl_Ayuda.Location = new System.Drawing.Point(7, 24);
            this.lbl_Ayuda.Name = "lbl_Ayuda";
            this.lbl_Ayuda.Size = new System.Drawing.Size(0, 15);
            this.lbl_Ayuda.TabIndex = 0;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.Color.White;
            this.lbl_Error.Location = new System.Drawing.Point(10, 403);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(10, 15);
            this.lbl_Error.TabIndex = 9;
            this.lbl_Error.Text = ".";
            // 
            // AltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 430);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Ayuda);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txb_Edad);
            this.Controls.Add(this.txb_Apellido);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.txb_Dni);
            this.Name = "AltaCliente";
            this.Text = "AltaCliente";
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_Dni;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.TextBox txb_Apellido;
        private System.Windows.Forms.TextBox txb_Edad;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Label lbl_Ayuda;
        private System.Windows.Forms.Label lbl_Error;
    }
}