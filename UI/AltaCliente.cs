using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace UI
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();

            gb_Datos.Visible = false;
        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (txb_Dni is not null && Validadora.ValidarNumeroConRango(txb_Dni.Text, 10000000, 50000000) && Validadora.ValidarLetras(txb_Apellido.Text) && txb_Edad is not null && Validadora.ValidarNumeroConRango(txb_Edad.Text, 1, 101) && Validadora.ValidarLetras(txb_Nombre.Text))
            {
                Cliente clienteNuevo = new Cliente(txb_Nombre.Text, txb_Apellido.Text, int.Parse(txb_Edad.Text), int.Parse(txb_Dni.Text), 0);

                if (!Cliente.ClienteExisteEnLista(clienteNuevo))
                {
                    AerolineaSistema.listaDeClientes.Add(clienteNuevo);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lbl_Error.Text = "El cliente ya existe";
                    lbl_Ayuda.Text = null;
                    gb_Datos.Visible = true;

                    lbl_Ayuda.Text = Cliente.ClienteExisteEnLista(clienteNuevo, ", ya fue creado").ToString();
                }

            }
            else
            {
                lbl_Error.Text = null;
                lbl_Error.Text = "Error";
            }
        }

        private void btn_Ayuda_Click_1(object sender, EventArgs e)
        {
            gb_Datos.Visible = true;
            lbl_Ayuda.Text = null;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1. Agregar DNI del cliente");
            sb.AppendLine("2. Agregar Nombre del cliente");
            sb.AppendLine("3. Agregar Apellido del cliente");
            sb.AppendLine("4. Agregar Edad del cliente");
            sb.AppendLine("5. Boton Agregar: Crea al cliente");

            sb.ToString();

            lbl_Ayuda.Visible = true;
            gb_Datos.Visible = true;

            lbl_Ayuda.Text = sb.ToString();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
