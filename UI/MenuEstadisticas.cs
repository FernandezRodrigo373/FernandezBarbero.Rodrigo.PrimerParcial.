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
    public partial class MenuEstadisticas : Form
    {
        List<Vuelo> lista;
        List<Cliente> listaDeClientes = new List<Cliente>();

        public MenuEstadisticas()
        {
            InitializeComponent();
        }
//
        private void MenuEstadisticas_Load(object sender, EventArgs e)
        {
            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtg_Datos.Visible = true;

            lista = AerolineaSistema.CargarVuelos();

            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = lista;


            btn_OrdenarDeManeraAscendente.Visible = false;
            btn_OrdenarDeManeraDescendente.Visible = false;

            gb_Ayuda.Visible = false;
        }

        private void btn_ListaDeDestinos_Click(object sender, EventArgs e)
        {
            lbl_DestinoMasElegido.Text = "Destino mas elegido:" + AerolineaSistema.MostrarDestinosMasElegido(lista);
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Ganancias_Click(object sender, EventArgs e)
        {
            //eDestinos destino = AerolineaSistema.ObtenerDestino(lista);
            int gananciasTotales = AerolineaSistema.ObtenerGananciasTotales(lista);
            int gananciasNacionales;
            int gananciasInternacionales;

            gananciasNacionales = AerolineaSistema.ObtenerGananciasNacional(lista);
            lbl_GananciasNacionales.Text = "Ganancias Nacionales:" + AerolineaSistema.CalcularGanancias(gananciasNacionales).ToString();

            gananciasInternacionales = AerolineaSistema.ObtenerGananciasInternacional(lista);

            lbl_GananciasInternacionales.Text = "Ganancias Internacionales:" + AerolineaSistema.CalcularGanancias(gananciasInternacionales).ToString();

            lbl_Totales.Text = "Ganancias Totales:" + gananciasTotales.ToString();
        }

        private void btn_HorasDeVuelo_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            AerolineaSistema.AumentarHorasDeVuelos(lista);

            dtg_Datos.DataSource = AerolineaSistema.CargarAviones();

            this.dtg_Datos.Columns["CantidadDeBanios"].Visible = false;
            this.dtg_Datos.Columns["CapacidadBodega"].Visible = false;
            this.dtg_Datos.Columns["CantidadDeAsientos"].Visible = false;
        }

        private void btn_PasajerosPorCantDeVuelos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AerolineaSistema.listaDeClientes.Count; i++)
            {
                if (AerolineaSistema.listaDeClientes[i].CantidadDeVuelos >= 3)
                {
                    listaDeClientes.Add(AerolineaSistema.listaDeClientes[i]);
                }
            }

            btn_OrdenarDeManeraAscendente.Visible = true;
            btn_OrdenarDeManeraDescendente.Visible = true;
        }

        private void btn_OrdenarDeManeraAscendente_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;

            listaDeClientes.Sort(Cliente.OrdenarListaDeClienteAscendente);
            dtg_Datos.DataSource = listaDeClientes;
        }

        private void btn_OrdenarDeManeraDescendente_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            listaDeClientes.Sort(Cliente.OrdenarListaDeClienteDescente);
            dtg_Datos.DataSource = listaDeClientes;
        }

        private void btn_ListaDeDestinosPorFacturacion_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;

            lista.Sort(Vuelo.OrdenarListaDeDestinosPorFacturacionDescente);

            dtg_Datos.DataSource = lista;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            gb_Ayuda.Visible = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(". Informes");
            sb.AppendLine("1. Destino mas elegido");
            sb.AppendLine("2. Ganancias");
            sb.AppendLine("3. Horas de Vuelo");
            sb.AppendLine("4. Pasajeros ordenador por cant de vuelos");
            sb.AppendLine("5. Destino ordenas por facturacion");



            sb.ToString();
            lbl_Ayuda.Visible = true;
            gb_Ayuda.Visible = true;

            lbl_Ayuda.Text = sb.ToString();
        }
    }
}