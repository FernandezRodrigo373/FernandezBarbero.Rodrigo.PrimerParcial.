using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuAerolinea : Form
    {
        List<Vuelo> listaFiltrada;
        Empleado empleado1;
        public MenuAerolinea(Empleado empleado)
        {
            InitializeComponent();


            if (empleado.correo == "admin@admin.com" && empleado.Clave == "12345678")
            {
                btn_RealizarSorteo.Visible = true;
                btn_ListaDeVuelos.Visible = false;
                btn_VenderVuelos.Visible = false;
                clientesToolStripMenuItem.Enabled = false;
            }
            else
            {
                btn_RealizarSorteo.Visible = false;
            }

            if(empleado.legajo > 0 && empleado.legajo < 4)
            {
                btn_CrearVuelos.Enabled = false;
                modificarAvionesToolStripMenuItem.Visible = false;

            }

            if (empleado.legajo == 4)
            {
                btn_ListaDeVuelos.Visible = false;
                btn_VenderVuelos.Visible = false;
                btn_CrearVuelos.Visible = false;

            }


            lbl_Operador.Text = empleado.Nombre + ' ' + empleado.Apellido;
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();


            txb_VueloABuscar.Visible = false;
            txb_ClienteABuscar.Visible = false;

            btn_BuscarCliente.Visible = false;
            btn_BuscarVuelosPorId.Visible = false;

            gb_MuestraDatos.Visible = false;

            empleado1 = empleado;

        }




        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            Refresh();
        }


        private void verListaDePasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txb_ClienteABuscar.Visible = true;
            string datoABuscar = txb_ClienteABuscar.Text;

            if (Validadora.ValidarLetras(datoABuscar))
            {
                List<Cliente> listaFiltrada = AerolineaSistema.BuscarClientePorNombre(datoABuscar);
                dtg_Datos.DataSource = listaFiltrada;
                dtg_Datos.AutoResizeColumns();
                dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtg_Datos.Visible = true;
            }
            else
            {
                lbl_Ayuda.Text = null;
                lbl_Ayuda.Text = "Error";
            }

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }



        private void btn_ListaDeVuelos_Click(object sender, EventArgs e)
        {

            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtg_Datos.Visible = true;

            List<Vuelo> lista;
            lista = AerolineaSistema.CargarVuelos();

            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = lista;
        }

        private void btn_CrearVuelos_Click(object sender, EventArgs e)
        {
            CrearVuelos menuCreacionVuelos = new CrearVuelos();
            //this.Hide();
            if (menuCreacionVuelos.ShowDialog() == DialogResult.OK)
            {
                dtg_Datos.Refresh();
            }

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cliente> lista;
            lista = AerolineaSistema.CargarClientes();

            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoResizeRows();

            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtg_Datos.Visible = true;
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = lista;
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dtg_Datos.Visible = true;
            txb_ClienteABuscar.Visible = true;
            btn_BuscarCliente.Visible = true;
        }

        private void darDeAltaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaCliente menuAltaCliente = new AltaCliente();

            if (menuAltaCliente.ShowDialog() == DialogResult.OK)
            {
                dtg_Datos.Refresh();
            }
        }

        private void btn_VenderVuelos_Click(object sender, EventArgs e)
        {
            AltaPasajero menuAltaPasajero = new AltaPasajero();


            if (menuAltaPasajero.ShowDialog() == DialogResult.OK)
            {
                dtg_Datos.Refresh();
            }
        }

        private void inoformeAvionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Avion> lista;

            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtg_Datos.Visible = true;
            lista = AerolineaSistema.CargarAviones();

            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = lista;
        }

        private void buscarVueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txb_VueloABuscar.Visible = true;
            btn_BuscarVuelosPorId.Visible = true;
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            string datoABuscar = txb_ClienteABuscar.Text;


            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txb_ClienteABuscar.Visible = true;
            dtg_Datos.Visible = true;


            List<Cliente> listaFiltrada = AerolineaSistema.BuscarClientePorNombre(datoABuscar);
            dtg_Datos.DataSource = listaFiltrada;
        }

        private void btn_ConsultarEstadisticas_Click(object sender, EventArgs e)
        {
            MenuEstadisticas menuEstadistica = new MenuEstadisticas();

            if (menuEstadistica.ShowDialog() == DialogResult.OK)
            {
                dtg_Datos.Refresh();
            }
        }

        private void btn_BuscarVuelosPorId_Click(object sender, EventArgs e)
        {
            txb_VueloABuscar.Visible = true;
            int datoABuscar = int.Parse(txb_VueloABuscar.Text);
            listaFiltrada = AerolineaSistema.BuscarVuelo(datoABuscar);
            dtg_Datos.DataSource = listaFiltrada;
            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtg_Datos.Visible = true;
            dtg_Dato2.DataSource = null;
            dtg_Dato2.Visible = true;
            dtg_Dato2.DataSource = listaFiltrada[0].ListaPasajeros;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RealizarSorteo_Click(object sender, EventArgs e)
        {
            SorteoCliente menuSorteo = new SorteoCliente();
            menuSorteo.Show();
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            gb_MuestraDatos.Visible = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1. Boton vizualizar vuelo imprime la lista de los mismos");
            sb.AppendLine("2. Boton crear vuelos vuelo permite crear nuevos vuelos");
            sb.AppendLine("3. Boton vender vuelo vende a un cliente un vuelo y lo asigna como pasajero");
            sb.AppendLine("4. Boton consultar estadisticas permite ver las estadisticas historicas");
            sb.AppendLine("5. Boton Listado de clientes (menu strip) muestra la lista de los mismos");
            sb.AppendLine("6. Boton Buscar clientes habilita la opcion de buscar cliente por su nombre");
            sb.AppendLine("7. Boton dar de alta cliente, da de alta a un cliente y lo añade a la base de datos");

            sb.ToString();
            lbl_Ayuda.Visible = true;
            gb_MuestraDatos.Visible = true;

            lbl_Ayuda.Text = sb.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // label1.Text = DateTime.Now.ToLongTimeString();
            lbl_Fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void modificarAvionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarAvion menuModificarAvion = new ModificarAvion();


            if (menuModificarAvion.ShowDialog() == DialogResult.OK)
            {
                dtg_Datos.Refresh();
            }
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarCliente menuModificarCliente = new ModificarCliente();

            if (menuModificarCliente.ShowDialog() == DialogResult.OK)
            {
                dtg_Datos.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuAerolinea_Load(object sender, EventArgs e)
        {
            txb_ClienteABuscar.Visible = false;
            btn_BuscarCliente.Visible = false;

            txb_VueloABuscar.Visible = false;
            btn_BuscarVuelosPorId.Visible = false;

            dtg_Datos.Visible = false;
            dtg_Dato2.Visible = false;

            gb_MuestraDatos.Visible = false;
            lbl_Ayuda.Visible = false;

            gb_MuestraDatos.Visible = false;
        }
    }
}
