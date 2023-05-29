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
            if (!String.IsNullOrEmpty( txt_Usuario.Text) && !String.IsNullOrEmpty(txt_Clave.Text))
            {


                try
                {
                    Empleado empleadoSolicitado = AerolineaSistema.ValidarLoginVendedores(txt_Usuario.Text, txt_Clave.Text);
                    MenuAerolinea menuAerolinea = new MenuAerolinea(empleadoSolicitado);

                    RegistroUsuarios.RegistrarAccesoUsuario(empleadoSolicitado.Nombre, empleadoSolicitado.Apellido, empleadoSolicitado.Perfil);
                    menuAerolinea.Show();


                }
                catch (Exception excepcion)
                {
                    lbl_Error.Show();
                    lbl_Error.Text = excepcion.Message;
                }
            }
            else
            {
                lbl_Error.Show();
                lbl_Error.Text = "ERROR";
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

        private void btn_AutocompletarSupervisor_Click(object sender, EventArgs e)
        {
            txt_Usuario.Text = "trobinson@super.com";
            txt_Clave.Text = "12345678";
        }

        private void btn_AutocompletarVendedor_Click_1(object sender, EventArgs e)
        {
            txt_Usuario.Text = "sharris@maiden.com.uk";
            txt_Clave.Text = "eddie666";
        }
    }
}
