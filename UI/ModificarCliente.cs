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
            if (!String.IsNullOrEmpty(txb_Dni.Text))
            {
                int datoABuscar = int.Parse(txb_Dni.Text);

                bool clienteExiste = false;

                for (int i = 0; i < AerolineaSistema.listaDeClientes.Count; i++)
                {
                    if (AerolineaSistema.listaDeClientes[i].Dni == datoABuscar)
                    {
                        AerolineaSistema.listaDeClientes.RemoveAt(i);
                        clienteExiste = true;
                        dtg_Datos.DataSource = null;
                        break;
                    }
                }

                if (clienteExiste)
                {
                    lbl_Error.Text = "Cliente borrado";
                }
                else
                {
                    lbl_Error.Text = "No se encontró el cliente";
                }

                dtg_Datos.DataSource = AerolineaSistema.listaDeClientes;
                dtg_Datos.AutoResizeColumns();
                dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                lbl_Error.Text = "Ingrese Dni";
            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Confirmar.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txb_Apellido.Visible = true;
            txb_Edad.Visible = true;
            txb_Nombre.Visible = true;

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txb_Dni.Text))
            {
                int datoABuscar = int.Parse(txb_Dni.Text);
                listaFiltrada = AerolineaSistema.BuscarClientePorDni(datoABuscar);
                dtg_Datos.DataSource = listaFiltrada;

                dtg_Datos.AutoResizeColumns();
                dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dtg_Datos.DataSource = listaFiltrada;

                btn_Eliminar.Visible = true;
                btn_Modificar.Visible = true;
            }
            else
            {
                lbl_Error.Text = "Ingrese Dni";

            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txb_Dni.Text))
            {
                int datoABuscar = int.Parse(txb_Dni.Text);

                for (int i = 0; i < AerolineaSistema.listaDeClientes.Count; i++)
                {
                    if (AerolineaSistema.listaDeClientes[i].Dni == datoABuscar)
                    {
                        if (txb_Nombre is not null && Validadora.ValidarLetras(txb_Nombre.Text) &&  txb_Apellido is not null && Validadora.ValidarLetras(txb_Apellido.Text)  && txb_Edad is not null && Validadora.ValidarNumeroConRango(txb_Edad.Text, 1, 101))
                        {
                            dtg_Datos.DataSource = null;
                            AerolineaSistema.listaDeClientes[i].Nombre = (txb_Nombre.Text);
                            AerolineaSistema.listaDeClientes[i].Apellido = (txb_Apellido.Text);
                            AerolineaSistema.listaDeClientes[i].Edad = int.Parse(txb_Edad.Text);
                            dtg_Datos.DataSource = AerolineaSistema.listaDeClientes[i];

                        }
                    }
                }

            }
        }
    

        private void ModificarCliente_Load(object sender, EventArgs e)
        {
            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = false;
            dtg_Datos.DataSource = AerolineaSistema.listaDeClientes;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            txb_Apellido.Visible = false;
            //txb_Dni.Visible = false;
            txb_Edad.Visible = false;
            txb_Nombre.Visible = false;
            btn_Confirmar.Visible = false;
        }

        private void btn_VerLista_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = AerolineaSistema.listaDeClientes;
        }
    }
}
