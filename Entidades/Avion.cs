using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion
    {
        private string matricula;
        private int cantidadDeAsientos;
        private int cantidadDeBanios;
        private int capacidadBodega;
        private int horasDeVuelos;
        private int cantidadDeAsientosPremium;
        private int cantidadDeAsientosTurista;


        public Avion(string matricula, int cantidadDeAsientos, int cantidadDeBaños, int capacidadBodega, int horasDeVuelo)
        {
            this.matricula = matricula;
            this.cantidadDeAsientos = cantidadDeAsientos;
            this.cantidadDeBanios = cantidadDeBaños;
            this.capacidadBodega = capacidadBodega;
            this.horasDeVuelos = horasDeVuelo;
            this.cantidadDeAsientosPremium = cantidadDeAsientos * 20 / 100;
            this.cantidadDeAsientosTurista = cantidadDeAsientos * 80 / 100;
        }


        public string Matricula
        {
            get { return matricula; }
        }
        public int CantidadDeAsientos
        {
            get { return cantidadDeAsientos; }
        }
        public int CantidadDeAsientosPremium
        {
            get { return cantidadDeAsientosPremium; }
        }

        public int CantidadDeAsientosTurista
        {
            get { return cantidadDeAsientosTurista; }
        }

        public int CantidadDeBanios
        {
            get { return cantidadDeBanios; }
        }

        public int CapacidadBodega
        {
            get { return capacidadBodega; }
        }

        public int HorasDeVuelos
        { 
            get { return horasDeVuelos; } 
            set { horasDeVuelos = value; }

        }

        public override string ToString()
        {
            return this.matricula;
        }

        public void CalcularHorasDeVuelo(List<Vuelo> vuelos)
        {
            int auxHoraDeVuelo = 0;

            if (vuelos is not null)
            {
                foreach (Vuelo item in AerolineaSistema.listaDeVuelos)
                {
                    if (item.UnAvion.Matricula == this.Matricula)
                    {
                        auxHoraDeVuelo += item.DuracionVuelo;
                    }
                }
            }

            this.HorasDeVuelos = auxHoraDeVuelo;
        }




    }
}
