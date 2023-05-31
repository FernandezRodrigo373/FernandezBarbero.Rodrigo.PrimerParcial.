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
    public partial class ModificarViaje : Form
    {
        public List<Vuelo> listaFiltrada;

        public ModificarViaje()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {


        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            eDestinos auxDestino = (eDestinos)cmb_Destino.SelectedIndex;
            eOrigen auxOrigen = (eOrigen)cmb_Origen.SelectedIndex;
      
            Avion avion = (Avion)cmb_Avion.SelectedItem;

            if (!String.IsNullOrWhiteSpace(txb_Piloto.Text.Trim()))
            {
                if (!String.IsNullOrEmpty(txb_Id.Text))
                {
                    int datoABuscar = int.Parse(txb_Id.Text);

                    for (int i = 0; i < AerolineaSistema.listaDeVuelos.Count; i++)
                    {
                        if (AerolineaSistema.listaDeVuelos[i].Id == datoABuscar)
                        {
                            if (txb_Piloto is not null && Validadora.ValidarLetras(txb_Piloto.Text))
                            {
                                dtg_Datos.DataSource = null;
                                AerolineaSistema.listaDeVuelos[i].NombrePiloto = (txb_Piloto.Text);
                                AerolineaSistema.listaDeVuelos[i].Destino = (auxDestino);
                                AerolineaSistema.listaDeVuelos[i].Origen = (auxOrigen);
                                AerolineaSistema.listaDeVuelos[i].UnAvion = (avion);
                                AerolineaSistema.listaDeVuelos[i].FechaYHoraDePartida = (dtp_Fecha.Value);
                                AerolineaSistema.listaDeVuelos[i].MatriculaDeAvionAsignado = (AerolineaSistema.listaDeVuelos[i].UnAvion.Matricula );

                                dtg_Datos.DataSource = AerolineaSistema.listaDeClientes[i];
                                break;
                            }
                        }
                    }

                }
                else
                {
                    lbl_Error.Visible = true;
                    lbl_Error.Text = "ERROR, Ingrese nombre del piloto para continuar";
                }
            }
        }

        private void ModificarViaje_Load(object sender, EventArgs e)
        {
            lbl_Error.Visible = false;
            cmb_Origen.Items.AddRange(Enum.GetNames(typeof(eOrigen)));
            cmb_Destino.Items.AddRange(Enum.GetNames(typeof(eDestinos)));

            cmb_Destino.SelectedIndex = 0;
            cmb_Origen.SelectedIndex = 0;

            AerolineaSistema.listaDeAviones = AerolineaSistema.CargarAviones();

            foreach (Avion item in AerolineaSistema.listaDeAviones)
            {
                cmb_Avion.Items.Add(item);
                cmb_Avion.SelectedIndex = 0;
            }

            dtp_Fecha.MinDate = DateTime.Today;

            btn_Modificar.Visible = false;
            btn_Eliminar.Visible = false;
            dtg_Datos.DataSource = AerolineaSistema.listaDeVuelos;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            btn_Confirmar.Visible = false;
            cmb_Avion.Visible = false;
            cmb_Destino.Visible = false;
            cmb_Origen.Visible = false;

            txb_Piloto.Visible = false;
            dtp_Fecha.Visible = false;


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txb_Id.Text))
            {
                int datoABuscar = int.Parse(txb_Id.Text);

                bool vueloExiste = false;

                for (int i = 0; i < AerolineaSistema.listaDeVuelos.Count; i++)
                {
                    if (AerolineaSistema.listaDeVuelos[i].Id == datoABuscar)
                    {
                        AerolineaSistema.listaDeVuelos.RemoveAt(i);
                        vueloExiste = true;
                        dtg_Datos.DataSource = null;
                        break;
                    }
                }

                if (vueloExiste)
                {
                    lbl_Error.Text = "vuelo borrado";
                }
                else
                {
                    lbl_Error.Text = "No se encontró el vuelo";
                }

                dtg_Datos.DataSource = AerolineaSistema.listaDeVuelos;
                dtg_Datos.AutoResizeColumns();
                dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                lbl_Error.Text = "Ingrese id";
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Confirmar.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            txb_Piloto.Visible = true;
            cmb_Avion.Visible = true;
            cmb_Destino.Visible = true;
            cmb_Origen.Visible = true;
            dtp_Fecha.Visible = true;

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txb_Id.Text))
            {
                int datoABuscar = int.Parse(txb_Id.Text);
                listaFiltrada = AerolineaSistema.BuscarVuelo(datoABuscar);
                dtg_Datos.DataSource = listaFiltrada;

                dtg_Datos.AutoResizeColumns();
                dtg_Datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                dtg_Datos.DataSource = listaFiltrada;

                btn_Eliminar.Visible = true;
                btn_Modificar.Visible = true;
            }
            else
            {
                lbl_Error.Text = "Ingrese id";

            }
        }

        private void btn_VerLista_Click(object sender, EventArgs e)
        {
            dtg_Datos.DataSource = null;
            dtg_Datos.DataSource = AerolineaSistema.listaDeVuelos;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
