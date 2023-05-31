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
        public int cantAviones = AerolineaSistema.listaDeAviones.Count;
        public List<Avion> listaFiltrada;
        public ModificarAvion()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
   

                if (txb_Matricula is not null && Validadora.ValidarNumeroConRango(txb_CantBanios.Text, 1, 6) && Validadora.ValidarNumeroConRango(txb_CantidadDeAsientos.Text, 50, 300) && txb_CantidadDeAsientos is not null && Validadora.ValidarNumeroConRango(txb_CapacidadBodega.Text, 200, 1000))
                {
                    Avion avionNuevo = new Avion(txb_Matricula.Text, int.Parse(txb_CantidadDeAsientos.Text), int.Parse(txb_CantBanios.Text), int.Parse(txb_CapacidadBodega.Text), 0);

                    for (int i = 0; i < AerolineaSistema.listaDeAviones.Count; i++)
                    {
                        if (avionNuevo.Matricula != AerolineaSistema.listaDeAviones[i].Matricula && cantAviones < 8)
                        {
                            AerolineaSistema.listaDeAviones.Add(avionNuevo);

                            dtg_Datos.DataSource = AerolineaSistema.listaDeAviones;
                            cantAviones++;
                            
                        }
                        else
                        {
                            lbl_CantidadDeAviones.Text = "ERROR";

                            dtg_Datos.Visible = true;

                            //lbl_CantidadDeAviones.Text = Avion.AvionYaExiste(avionNuevo, " ya existe ").ToString();
                        }
                    }


                }
                else
                {

                    lbl_CantidadDeAviones.Text = "Error";
                }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_BuscaAvion_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txb_AvionID.Text))
            {
                string datoABuscar = (txb_AvionID.Text);
                listaFiltrada = AerolineaSistema.BuscarAvion(datoABuscar);
                dtg_Datos.DataSource = listaFiltrada;

                dtg_Datos.AutoResizeColumns();
                dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dtg_Datos.DataSource = listaFiltrada;

                btn_EliminarAvion.Visible = true;
                btn_Modificar.Visible = true;
                btn_ConfrimarModifica.Visible = true;
            }
            else
            {
                lbl_Error.Text = "Ingrese matricula";

            }
        }

        private void btn_EliminarAvion_Click(object sender, EventArgs e)
        {

      
                if (!String.IsNullOrEmpty(txb_AvionID.Text))
                {

                    string datoABuscar = txb_AvionID.Text;

                    bool avionExiste = false;

                    for (int i = 0; i < AerolineaSistema.listaDeAviones.Count; i++)
                    {
                        if (AerolineaSistema.listaDeAviones[i].Matricula == datoABuscar)
                        {
                            AerolineaSistema.listaDeAviones.RemoveAt(i);
                            avionExiste = true;
                            dtg_Datos.DataSource = null;

                            break;
                        }
                    }

                    if (avionExiste)
                    {
                        lbl_Error.Text = "Avion borrado";
                        cantAviones--;
                    }
                    else
                    {
                        lbl_Error.Text = "No se encontró el avion";
                    }

                    dtg_Datos.DataSource = AerolineaSistema.listaDeAviones;
                    dtg_Datos.AutoResizeColumns();
                    dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    lbl_Error.Text = "Ingrese Matricula";
                }


            /*
            }
            else
            {
                lbl_Error.Text = "No se pueden eliminar mas aviones";
            }*/
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {


            btn_ConfrimarModifica.Visible = true;
            txb_ModificaMatricula.Visible = true ;
            txb_ModificaBanios.Visible = true;
            txb_ModificaBodega.Visible = true ;
            txb_ModificaAsientos.Visible = true;


        }

        private void btn_ConfrimarModifica_Click(object sender, EventArgs e)
        {

           

                if (!String.IsNullOrEmpty(txb_AvionID.Text))
                {
                    string datoABuscar = (txb_AvionID.Text);

                    for (int i = 0; i < AerolineaSistema.listaDeAviones.Count; i++)
                    {
                        if (AerolineaSistema.listaDeAviones[i].Matricula == datoABuscar)
                        {
                            if (txb_Matricula is not null && Validadora.ValidarNumeroConRango(txb_CantBanios.Text, 1, 6) && Validadora.ValidarNumeroConRango(txb_CantidadDeAsientos.Text, 50, 300) && txb_CantidadDeAsientos is not null && Validadora.ValidarNumeroConRango(txb_CapacidadBodega.Text, 200, 1000))
                            {
                                AerolineaSistema.listaDeAviones[i].Matricula = (txb_Matricula.Text);
                                AerolineaSistema.listaDeAviones[i].CantidadDeBanios = int.Parse(txb_ModificaBanios.Text);
                                AerolineaSistema.listaDeAviones[i].CantidadDeAsientos = int.Parse(txb_ModificaAsientos.Text);
                                AerolineaSistema.listaDeAviones[i].CapacidadBodega = int.Parse(txb_ModificaBodega.Text);
                                dtg_Datos.DataSource = null;

                                dtg_Datos.DataSource = AerolineaSistema.listaDeAviones[i];

                            }
                        }
                    }

                }


        
        }

        private void btn_CrearAvion_Click(object sender, EventArgs e)
        {
            btn_Confirmar.Visible = true;
            txb_Matricula.Visible = true;
            txb_CantBanios.Visible = true;
            txb_CantidadDeAsientos.Visible = true;
            txb_CapacidadBodega.Visible = true;
        }

        private void ModificarAvion_Load(object sender, EventArgs e)
        {
            btn_CrearAvion.Visible = true;
            btn_Modificar.Visible = false;

            btn_Confirmar.Visible = false;
            txb_Matricula.Visible = false;
            txb_CantBanios.Visible = false;
            txb_CantidadDeAsientos.Visible = false;
            txb_CapacidadBodega.Visible = false;

            txb_ModificaMatricula.Visible = false;
            txb_ModificaBanios.Visible = false;
            txb_ModificaBodega.Visible = false;
            txb_ModificaAsientos.Visible = false;
            btn_ConfrimarModifica.Visible = false;

            btn_EliminarAvion.Visible = false;

            dtg_Datos.DataSource = AerolineaSistema.listaDeAviones;

        }

        private void btn_VerLista_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = AerolineaSistema.listaDeAviones;
        }
    }
}
