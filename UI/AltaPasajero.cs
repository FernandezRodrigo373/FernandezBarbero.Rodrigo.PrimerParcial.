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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace UI
{
    public partial class AltaPasajero : Form
    {
        private int precioVuelo = 0;
        private int indexCliente;
        private int indexVuelo;
        private int precioNeto = 0;
        private Pasajero nuevoPasajero;
        private Cliente auxCliente;
        private Vuelo auxVuelo;
        List<Vuelo> listaFiltrada;


        private int pesoValijas = 0;
        // public int acumuladorRecaudacionDestino = 0;

        public AltaPasajero()
        {
            InitializeComponent();

            gb_Ayuda.Visible = false;
        }

        private void dtg_DatosAMostrar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexVuelo = dtg_DatosAMostrar.CurrentRow.Index;
        }


        private void dtg_DatosAMostrar2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexCliente = dtg_DatosAMostrar2.CurrentRow.Index;
        }



        /// <summary>
        /// Verifica si esta agregado la seccion wifi y eleva el precio
        /// </summary>
        /// <returns></returns>
        private int VerificarWifi()
        {
            int acumulador = 0;
            if (chb_Wifi.Checked == true)
            {
                acumulador += 3;
            }
            return acumulador;
        }

        /// <summary>
        /// Verifica si esta agregado la seccion comida y eleva el precio
        /// </summary>
        /// <returns></returns>
        private int VerificarComida()
        {
            int acumulador = 0;
            if (chb_Comida.Checked == true)
            {
                acumulador += 4;
            }
            return acumulador;
        }

        /// <summary>
        /// Verifica si esta agregado la seccion peliculas y eleva el precio
        /// </summary>
        /// <returns></returns>
        private int VerificarPeliculas()
        {
            int acumulador = 0;

            if (chb_Peliculas.Checked == true)
            {
                acumulador += 2;
            }
            return acumulador;
        }


        private eEquipaje VerificarEquipajeDeMano()
        {
            eEquipaje equipaje = 0;
            if (rb_NoLLevaBolsoDeMano.Checked == true)
            {
                equipaje = eEquipaje.sinEquipaje;
                rb_LlevaBolsoDeMano.Checked = false;
            }
            else if (rb_LlevaBolsoDeMano.Checked == true)
            {
                rb_NoLLevaBolsoDeMano.Checked = false;

                equipaje = eEquipaje.deMano;
            }
            return equipaje;
        }
        private eEquipaje VerificarEquipajeDeBodega(int valija1, int valija2)
        {
            eEquipaje equipaje = 0;
            pesoValijas = 0;

            equipaje = eEquipaje.deBodega;
            pesoValijas += valija1;

            pesoValijas += valija2;


            if (rb_LlevaBolsoDeMano.Checked == true)
            {
                equipaje = eEquipaje.deMano;

            }
            else if (rb_LlevaBolsoDeMano.Checked == false)
            {
                txb_PesoValija1.Text = 0.ToString();
                txb_PesoValija2.Text = 0.ToString();
                pesoValijas = 0;
                equipaje = eEquipaje.sinEquipaje;
            }

            return equipaje;
        }



        /// <summary>
        /// Verifica la clase elegida y cambia el precio
        /// </summary>
        /// <returns></returns>
        private eClase VerificarClase()
        {
            eClase clase = 0;

            if (rb_ClasePremium.Checked == true)
            {
                clase = eClase.premium;
                // rb_ClaseTurista.Checked = false;
            }
            else if (rb_ClaseTurista.Checked == true)
            {
                //rb_ClasePremium.Checked = false;



                clase = eClase.turista;
            }
            return clase;
        }


        private void rb_ClaseTurista_CheckedChanged(object sender, EventArgs e)
        {
            txb_PesoValija2.Enabled = false;
        }

        private void rb_ClasePremium_CheckedChanged(object sender, EventArgs e)
        {
            txb_PesoValija2.Enabled = true;
        }

/// //////////////////////

        private void AltaPasajero_Load(object sender, EventArgs e)
        {
            dtg_DatosAMostrar.AutoResizeColumns();
            dtg_DatosAMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            List<Vuelo> lista;
            lista = AerolineaSistema.CargarVuelos();

            dtg_DatosAMostrar.DataSource = null;
            dtg_DatosAMostrar.DataSource = lista;

            List<Cliente> listaClientes;
            listaClientes = AerolineaSistema.CargarClientes();

            dtg_DatosAMostrar2.AutoResizeColumns();
            dtg_DatosAMostrar2.AutoResizeRows();

            dtg_DatosAMostrar2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtg_DatosAMostrar2.DataSource = null;
            dtg_DatosAMostrar2.DataSource = listaClientes;

            btn_FinalizarOperacion.Visible = false;

            rb_LlevaBolsoDeMano.Checked = true;

            rb_CantPasajes1.Checked = true;
        }

        private void btn_CalcularPrecio_Click(object sender, EventArgs e)
        {
            int duracion;
            int acumuladorTotal = 0;
            int precioBruto = 0;
            int impuestoPais = precioBruto * 30 / 100;
            int impuestoTurismo = precioBruto * 45 / 100;
            int acumuladorWifi = VerificarWifi();
            int acumuladorComida = VerificarComida();
            int acumuladorPeliculas = VerificarPeliculas();

            auxCliente = Cliente.ObtenerCliente(AerolineaSistema.listaDeClientes, indexCliente);

            auxVuelo = Vuelo.ObtenerVuelo(AerolineaSistema.listaDeVuelos, indexVuelo);



            if (auxVuelo.DuracionVuelo < 5)
            {
                duracion = auxVuelo.DuracionVuelo;
                precioVuelo = duracion * 50;
            }
            else
            {
                duracion = auxVuelo.DuracionVuelo;
                precioVuelo = duracion * 100;
            }
            acumuladorTotal = acumuladorWifi + acumuladorComida + acumuladorPeliculas;
            precioBruto = acumuladorTotal + precioVuelo;
            precioNeto = precioBruto + impuestoPais + impuestoTurismo;

            if (rb_CantPasajes1.Checked == true)
            {
                precioNeto *= 1;
            }
            else if (rb_CantPasajes2.Checked == true)
            {
                precioNeto *= 2;
            }
            else if (rb_CantPasajes3.Checked == true)
            {
                precioNeto *= 3;
            }
            else
            {
                precioNeto *= 4;
                precioNeto -= 75;
            }


            if (rb_ClasePremium.Checked == true)
            {
                precioNeto = precioNeto + precioNeto * 15 / 100;
            }

            lbl_TextoPrecioBruto.Text = "Precio Bruto: ";
            lbl_PrecioBruto.Text = precioBruto.ToString();

            lbl_TextoPrecioNeto.Text = "Precio Neto(con impuestos): ";
            lbl_PrecioNeto.Text = precioNeto.ToString();

            btn_FinalizarOperacion.Visible = true;
        }

        private void btn_FinalizarOperacion_Click(object sender, EventArgs e)
        {
            eClase clase = VerificarClase();

            int pesoValija1 = 0;
            int pesoValija2 = 0;


            if (String.IsNullOrEmpty(txb_PesoValija1.Text))
            {
                pesoValija1 = 0;
            }
            else
            {
                pesoValija1 = int.Parse(txb_PesoValija1.Text);

            }


            if (clase == eClase.turista)
            {
                pesoValija2 = 0;

                if (pesoValija1 > 25 || pesoValija1 < 0)
                {
                    lbl_Error.Text = null;
                    lbl_Error.Text = "El peso de la valija debe ser hasta 25kg";
                }



            }
            else if (clase == eClase.premium)
            {

                if (!String.IsNullOrWhiteSpace(txb_PesoValija2.Text))
                {
                    pesoValija2 = int.Parse(txb_PesoValija2.Text);

                }
                else
                {
                    pesoValija2 = 0;
                }

                if (pesoValija1 > 21 || pesoValija1 < 0)
                {
                    lbl_Error.Text = null;
                    lbl_Error.Text = "El peso de las valijas debe ser hasta 21kg";
                }

            }

            if (auxVuelo.CantidadDeAsientosDisponibles > 0)
            {
                nuevoPasajero = new Pasajero(auxCliente, VerificarEquipajeDeMano(), VerificarEquipajeDeBodega(pesoValija1, pesoValija2), clase, precioNeto, pesoValijas);

            }
            else
            {
                lbl_Error.Text = null;
                lbl_Error.Text = "Avion lleno, Elija otro destino";
            }


            if (nuevoPasajero is not null /*&& Pasajero.ConfirmarSiPasajeroExisteEnVuelo(nuevoPasajero, auxVuelo)*/)
            {
                lbl_Error.Text = null;
                auxVuelo.AgregarPasajeroALista(nuevoPasajero);
                auxVuelo.CantidadDeAsientosDisponibles -= 1;
                auxCliente.CantidadDeVuelos++;
                auxVuelo.TotalCostopasajes += precioNeto;

                if (nuevoPasajero.Clase == eClase.premium.ToString())
                {
                    auxVuelo.CapacidadDeAsientosPremium--;
                }

                if (nuevoPasajero.Clase == eClase.turista.ToString())
                {
                    auxVuelo.CapacidadDeAsientosTurista--;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbl_Error.Text = null;
                lbl_Error.Text = "El pasajero ya existe en este vuelo";
            }
        }

        private void btn_BuscarCliente_Click(object sender, EventArgs e)
        {
            string datoABuscar;

            if (!String.IsNullOrEmpty(txb_NombreCliente.Text))
            {
                datoABuscar = txb_NombreCliente.Text;
                List<Cliente> listaFiltrada = AerolineaSistema.BuscarClientePorNombre(datoABuscar);
                dtg_DatosAMostrar2.AutoResizeColumns();
                dtg_DatosAMostrar2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dtg_DatosAMostrar2.DataSource = listaFiltrada;
            }
            else
            {
                lbl_ConfirmacionPasajero.Text = "Ingrese datos nuevamente";
            }
        }

        private void btn_BuscarVuelo_Click(object sender, EventArgs e)
        {
            int datoABuscar;
            txb_IdVuelo.Visible = true;
            if (!String.IsNullOrEmpty(txb_IdVuelo.Text))
            {
                datoABuscar = int.Parse(txb_IdVuelo.Text);
                listaFiltrada = AerolineaSistema.BuscarVuelo(datoABuscar);
                dtg_DatosAMostrar.DataSource = listaFiltrada;
                dtg_DatosAMostrar.AutoResizeColumns();
                dtg_DatosAMostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
            else
            {
                lbl_ConfirmacionPasajero.Text = "Ingrese datos nuevamente";
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

            sb.AppendLine("1. Seleccionar un cliente de entre la lista");
            sb.AppendLine("2. Seleccionar vuelo a vender al cliente");
            sb.AppendLine("3. Calcular precio arroja info del pago");
            sb.AppendLine("4. Permite elegir cantidad de pasajes(proporciona descuento)");
            sb.AppendLine("5. Finalizar Operacion agrega al pasajero");
            sb.AppendLine("6. ---------------");
            sb.AppendLine("7. Se puede buscar un cliente por su nombre");
            sb.AppendLine("8. Se puede buscar un vuelo por su id");
            sb.AppendLine("9. Seleccione preferencia del cliente\n en los cuadros de texto (cambia el precio final)");


            sb.ToString();
            lbl_Ayuda.Visible = true;
            gb_Ayuda.Visible = true;

            lbl_Ayuda.Text = sb.ToString();
        }
    }
}
