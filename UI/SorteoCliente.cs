using Entidades;
using System;
using System.Collections;
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
    public partial class SorteoCliente : Form
    {
        List<Cliente> listaDeClientes;
        List<Vuelo> listaDeVuelos;
        private Vuelo auxVuelo;
        private int indexVuelo;
        private Pasajero nuevoPasajero;
        private Cliente auxCliente;
       // Dictionary<string, int> clientesYaGanadores;

        public SorteoCliente()
        {
            InitializeComponent();


        }

        private void SorteoCliente_Load(object sender, EventArgs e)
        {
            listaDeClientes = AerolineaSistema.CargarClientes();

            dtg_Datos.DataSource = null;

            dtg_Datos.DataSource = listaDeClientes;

            lbl_Mensaje.Visible = false;

            gb_Ayuda.Visible = false;

        }
        private void dtg_Datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexVuelo = dtg_Datos.CurrentRow.Index;
        }

        private void btn_RealizarSorteo_Click(object sender, EventArgs e)
        {
            int contador = 0;
            listaDeVuelos = AerolineaSistema.CargarVuelos();

            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = listaDeVuelos;

            Random rnd = new Random();
            int index = rnd.Next(0, listaDeClientes.Count);

           
            AerolineaSistema.clientesYaGanadores.Add(listaDeClientes[index].Nombre, listaDeClientes[index].Dni);

            lbx_GanadorSorteo.Items.Add("Nombre");
            lbx_GanadorSorteo.Items.Add (listaDeClientes[index].Nombre);
            lbx_GanadorSorteo.Items.Add(" \n\n");

            lbx_GanadorSorteo.Items.Add("Apellido");
            lbx_GanadorSorteo.Items.Add (listaDeClientes[index].Apellido);
            lbx_GanadorSorteo.Items.Add(" \n\n");



            lbx_GanadorSorteo.Items.Add("Dni");
            lbx_GanadorSorteo.Items.Add (listaDeClientes[index].Dni);

            auxVuelo = Vuelo.ObtenerVuelo(AerolineaSistema.listaDeVuelos, indexVuelo);

            auxCliente = Cliente.ObtenerCliente(listaDeClientes, index);

            contador = 1;

            if(contador > 0)
            {
                btn_RealizarSorteo.Enabled = false;
            }

        }



        private void btn_AgregarPasajero_Click(object sender, EventArgs e)
        {
            int error = 0;

            lbl_Mensaje.Visible = true;


            if (auxVuelo.CantidadDeAsientosDisponibles > 0)
            {
                nuevoPasajero = new Pasajero(auxCliente, eEquipaje.deBodega, eEquipaje.deMano, eClase.premium, 0, 40);
            }
            else
            {
                lbl_Mensaje.Text = null;

                lbl_Mensaje.Text = "ERROR, VUELO LLENO"; 
            }

            if (nuevoPasajero is not null)
            {

                if (Pasajero.ConfirmarSiPasajeroExisteEnVuelo(nuevoPasajero, auxVuelo))
                {
                    lbl_Mensaje.Text = null;
                    lbl_Mensaje.Text = "ERROR, EL PASAJERO YA SE ENCUENTRA EN ESTE VUELO"; 
                    error = 1;

                }

                if (error == 0)
                {
                    auxVuelo.AgregarPasajeroALista(nuevoPasajero);

                    lbl_Mensaje.Text = null;

                    lbl_Mensaje.Text = "Pasajero añadido al vuelo de manera correcta";
                    this.DialogResult = DialogResult.OK;
                }


            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            gb_Ayuda.Visible = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1. Boton realizar sorteo elige un cliente");
            sb.AppendLine("2. Boton agregar pasajero agrega el cliente al vuelo seleccionado");
            sb.AppendLine("3. Boton salir para finalizar");

            sb.ToString();
            lbl_Ayuda.Visible = true;
            gb_Ayuda.Visible = true;

            lbl_Ayuda.Text = sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtg_ClientesGanadores.DataSource = AerolineaSistema.clientesYaGanadores.ToList();
        }
    }
}
