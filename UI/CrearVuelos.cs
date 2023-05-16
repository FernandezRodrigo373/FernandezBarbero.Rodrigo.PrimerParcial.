using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class CrearVuelos : Form
    {
        public CrearVuelos()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {


        }







        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            List<Pasajero> lista = new List<Pasajero>();
            eDestinos auxDestino = (eDestinos)cmb_Destino.SelectedIndex;
            eOrigen auxOrigen = (eOrigen)cmb_Origen.SelectedIndex;
            Random r = new Random();
            int id = r.Next(3, 10000);
            int duracionVueloNacional = r.Next(2, 4);
            int duracionVueloInternacional = r.Next(8, 12);
            Avion avion = (Avion)cmb_Avion.SelectedItem;

            if (!String.IsNullOrWhiteSpace(txb_Piloto.Text.Trim()))
            {
                if (cmb_Destino.SelectedIndex > 16 || cmb_Origen.SelectedIndex > 16)
                {
                    AerolineaSistema.listaDeVuelos.Add(new Vuelo(id, duracionVueloInternacional, auxOrigen, auxDestino, dtp_Fecha.Value, txb_Piloto.Text, cmb_Avion.SelectedItem.ToString(), (Avion)cmb_Avion.SelectedItem, "Disponible", lista, avion.CantidadDeAsientos));
                }
                else
                {
                    AerolineaSistema.listaDeVuelos.Add(new Vuelo(id, duracionVueloNacional, auxOrigen, auxDestino, dtp_Fecha.Value, txb_Piloto.Text, cmb_Avion.SelectedItem.ToString(), (Avion)cmb_Avion.SelectedItem, "Disponible", lista, avion.CantidadDeAsientos));
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lbl_Error.Visible = true;
                lbl_Error.Text = "ERROR, Ingrese nombre del piloto para continuar";
            }
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            gb_Ayuda.Visible = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1. Seleccionar origen del vuelo");
            sb.AppendLine("2. Seleccionar destino del vuelo");
            sb.AppendLine("3. Seleccionar fecha del vuelo");
            sb.AppendLine("4. Seleccionar avion del vuelo");
            sb.AppendLine("5. Asignar piloto del vuelo");
            sb.AppendLine("6. ---------------");



            sb.ToString();
            lbl_Ayuda.Visible = true;
            gb_Ayuda.Visible = true;

            lbl_Ayuda.Text = sb.ToString();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CrearVuelos_Load_1(object sender, EventArgs e)
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

            gb_Ayuda.Visible = false;
        }

        private void cmb_Destino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Origen.Focused && cmb_Origen.SelectedIndex > 15 && cmb_Destino.SelectedIndex != 0)
            {
                lbl_Mensaje.Text = "Vuelos internacionales solo tienen como destino BS.AS";
                cmb_Destino.SelectedIndex = 0;
                cmb_Destino.Enabled = false;
                btn_Agregar.Enabled = false;    
            }
        }
    }
}
