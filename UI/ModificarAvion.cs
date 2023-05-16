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
    public partial class ModificarAvion : Form
    {
        public int cantAviones;
        public List<Avion> listaFiltrada;
        public ModificarAvion()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (cantAviones < 7 && cantAviones > -1)
            {

                if (txb_Matricula is not null && Validadora.ValidarNumeroConRango(txb_CantBanios.Text, 1, 6) && Validadora.ValidarNumeroConRango(txb_CantidadDeAsientos.Text, 50, 300) && txb_CantidadDeAsientos is not null && Validadora.ValidarNumeroConRango(txb_CapacidadBodega.Text, 200, 1000))
                {
                    Avion avionNuevo = new Avion(txb_Matricula.Text, int.Parse(txb_CantidadDeAsientos.Text), int.Parse(txb_CantBanios.Text), int.Parse(txb_CapacidadBodega.Text), 0);

                    for (int i = 0; i < AerolineaSistema.listaDeAviones.Count; i++)
                    {
                        if (avionNuevo.Matricula != AerolineaSistema.listaDeAviones[i].Matricula)
                        {
                            AerolineaSistema.listaDeAviones.Add(avionNuevo);

                            dtg_Datos.DataSource = AerolineaSistema.listaDeAviones;
                            cantAviones++;
                        }
                        else
                        {
                            lbl_CantidadDeAviones.Text = "El avion ya existe";

                            dtg_Datos.Visible = true;

                            lbl_CantidadDeAviones.Text = Avion.AvionYaExiste(avionNuevo, " ya existe ").ToString();
                        }
                    }


                }
                else
                {

                    lbl_CantidadDeAviones.Text = "Error";
                }
            }
            else
            {
                lbl_CantidadDeAviones.Text = "Cantidad de aviones no puede superar los 7. Primero elimine uno";
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_BuscaAvion_Click(object sender, EventArgs e)
        {
            string datoABuscar = txb_AvionID.Text;
            listaFiltrada = AerolineaSistema.BuscarAvion(datoABuscar);
            dtg_Datos.DataSource = listaFiltrada;

            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dtg_Datos.DataSource = listaFiltrada[0];
        }

        private void btn_EliminarAvion_Click(object sender, EventArgs e)
        {
            string datoABuscar = txb_AvionID.Text;
            listaFiltrada = AerolineaSistema.BuscarAvion(datoABuscar);

            AerolineaSistema.listaDeAviones.Remove(listaFiltrada[0]);
            cantAviones--;

            dtg_Datos.AutoResizeColumns();
            dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {


            btn_ConfrimarModifica.Visible = true;


        }

        private void btn_ConfrimarModifica_Click(object sender, EventArgs e)
        {
            string datoABuscar = txb_AvionID.Text;
            listaFiltrada = AerolineaSistema.BuscarAvion(datoABuscar);


            if (cantAviones < 7 && cantAviones > -1)
            {

                if (txb_Matricula is not null && Validadora.ValidarNumeroConRango(txb_CantBanios.Text, 1, 6) && Validadora.ValidarNumeroConRango(txb_CantidadDeAsientos.Text, 50, 300) && txb_CantidadDeAsientos is not null && Validadora.ValidarNumeroConRango(txb_CapacidadBodega.Text, 200, 1000))
                {
                    listaFiltrada[0].Matricula = txb_ModificaMatricula.Text;
                    listaFiltrada[0].CantidadDeBanios = int.Parse( txb_ModificaBanios.Text);
                    listaFiltrada[0].CantidadDeAsientos = int.Parse(txb_ModificaAsientos.Text);
                    listaFiltrada[0].CapacidadBodega = int.Parse(txb_ModificaBodega.Text);



                }
                else
                {
                    lbl_CantidadDeAviones.Text = "ERROR, ingrese datos nuevamente";
                }
            }
        }

        private void btn_CrearAvion_Click(object sender, EventArgs e)
        {
            btn_CrearAvion.Visible = true;
        }

        private void ModificarAvion_Load(object sender, EventArgs e)
        {
            btn_CrearAvion.Visible = false;
            btn_ConfrimarModifica.Visible = false;

        }
    }
}
