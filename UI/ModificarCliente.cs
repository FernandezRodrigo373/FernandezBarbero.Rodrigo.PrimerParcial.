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

namespace UI
{
    public partial class ModificarCliente : Form
    {

        public List<Cliente> listaFiltrada;
        public ModificarCliente()
        {
            InitializeComponent();
        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int datoABuscar = int.Parse(txb_Dni.Text);
            listaFiltrada = AerolineaSistema.BuscarClientePorNombre(datoABuscar.ToString());

            AerolineaSistema.listaDeClientes.Remove(listaFiltrada[0]);

            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Confirmar.Visible = true;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            int datoABuscar = int.Parse(txb_Dni.Text);
            listaFiltrada = AerolineaSistema.BuscarClientePorDni(datoABuscar);
            dtg_Datos.DataSource = listaFiltrada;

            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtg_Datos.DataSource = listaFiltrada[0];
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            int datoABuscar = int.Parse(txb_Dni.Text);
            listaFiltrada = AerolineaSistema.BuscarClientePorDni(datoABuscar);



            if (txb_Dni is not null && Validadora.ValidarNumeroConRango(txb_Dni.Text, 1, 1000000) && Validadora.ValidarLetras(txb_Nombre.Text) && txb_Nombre is not null && Validadora.ValidarLetras(txb_Apellido.Text) && txb_Nombre is not null && txb_Edad is not null && Validadora.ValidarNumeroConRango(txb_Edad.Text, 1, 101))
            {
                listaFiltrada[0].Nombre = (txb_Nombre.Text);
                listaFiltrada[0].Apellido = (txb_Apellido.Text);
                listaFiltrada[0].Edad = int.Parse(txb_Edad.Text);



            }
            else
            {
                lbl_Error.Text = "ERROR, ingrese datos nuevamente";
            }
            
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            btn_Modificar.Visible = false;
        }
    }
}
