namespace UI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Clave = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "CeliAirlines";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Usuario.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Usuario.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Usuario.Location = new System.Drawing.Point(104, 89);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(58, 22);
            this.lbl_Usuario.TabIndex = 11;
            this.lbl_Usuario.Text = "USUARIO";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Usuario.Location = new System.Drawing.Point(47, 114);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(195, 25);
            this.txt_Usuario.TabIndex = 10;
            // 
            // lbl_Clave
            // 
            this.lbl_Clave.AutoSize = true;
            this.lbl_Clave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Clave.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Clave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Clave.Location = new System.Drawing.Point(104, 163);
            this.lbl_Clave.Name = "lbl_Clave";
            this.lbl_Clave.Size = new System.Drawing.Size(46, 22);
            this.lbl_Clave.TabIndex = 14;
            this.lbl_Clave.Text = "CLAVE";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Clave.Location = new System.Drawing.Point(47, 188);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(195, 25);
            this.txt_Clave.TabIndex = 13;
            this.txt_Clave.UseSystemPasswordChar = true;
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.BackColor = System.Drawing.Color.White;
            this.btn_Autocompletar.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Autocompletar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btn_Autocompletar.Location = new System.Drawing.Point(84, 286);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(116, 24);
            this.btn_Autocompletar.TabIndex = 16;
            this.btn_Autocompletar.Text = "AUTOCOMPLETAR";
            this.btn_Autocompletar.UseVisualStyleBackColor = false;
            this.btn_Autocompletar.Click += new System.EventHandler(this.btn_Autocompletar_Click_1);
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Ingresar.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_Ingresar.Location = new System.Drawing.Point(47, 247);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(195, 33);
            this.btn_Ingresar.TabIndex = 15;
            this.btn_Ingresar.Text = "INGRESAR";
            this.btn_Ingresar.UseVisualStyleBackColor = false;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click_1);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Location = new System.Drawing.Point(215, 307);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 32);
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_Error.Location = new System.Drawing.Point(12, 367);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(10, 15);
            this.lbl_Error.TabIndex = 17;
            this.lbl_Error.Text = "l";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "label2";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lbl_Clave);
            this.Controls.Add(this.txt_Clave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Usuario);
            this.Controls.Add(this.txt_Usuario);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Clave;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Button btn_Autocompletar;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
