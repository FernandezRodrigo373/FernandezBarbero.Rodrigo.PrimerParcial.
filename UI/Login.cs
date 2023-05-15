using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lbl_Error.Hide();
        }



        public void LimpiarPantalla()
        {
            txt_Usuario.Text = String.Empty;
            txt_Clave.Text = String.Empty;

        }





        private void btn_Ingresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Empleado empleadoSolicitado = AerolineaSistema.ValidarLoginVendedores(txt_Usuario.Text, txt_Clave.Text);
                MenuAerolinea menuAerolinea = new MenuAerolinea(empleadoSolicitado);
                menuAerolinea.Show();
            }
            catch (Exception excepcion)
            {
                lbl_Error.Show();
                lbl_Error.Text = excepcion.Message;
            }
        }

        private void btn_Autocompletar_Click_1(object sender, EventArgs e)
        {
            txt_Usuario.Text = "admin@admin.com";
            txt_Clave.Text = "12345678";
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var empleado in AerolineaSistema. listaEmpleados)
            {
             label2.Text = empleado.ToString();
            }
        }
    }
}
