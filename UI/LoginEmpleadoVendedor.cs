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
    public partial class LoginEmpleadoVendedor : Form
    {
        public LoginEmpleadoVendedor()
        {
            InitializeComponent();
            lbl_Error.Hide();
        }

        
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {

            try
            {
                Vendedor vendedorSolicitado = AerolineaSistema.ValidarLoginVendedores(txt_Usuario.Text, txt_Clave.Text);
                MenuAerolinea menuAerolinea = new MenuAerolinea(vendedorSolicitado);
                menuAerolinea.Show();
            }
            catch(Exception excepcion)
            {
               lbl_Error.Show();
               lbl_Error.Text = excepcion.Message;
            }

        }

        private void btn_Autocompletar_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = "rodrigo.fernandez";
            txt_Clave.Text = "123";
        }

        public void LimpiarPantalla()
        {
            txt_Usuario.Text = String.Empty;
            txt_Clave.Text = String.Empty;
        
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
