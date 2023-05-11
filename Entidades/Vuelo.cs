using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vuelo
    {
        private int id = 0;
        private int duracionVuelo;
        private int cantidadDeAsientosOcupados;
        private int capacidadDeAsientosPremium;
        private int capacidadDeAsientosTurista;
        private eOrigen origen;
        private eDestinos destino;
        private DateTime horaDePartida;
        private string nombrePiloto;
        string matriculaDeAvionAsignado;
        string estado;
        private List<Pasajero> listaDePasajeros;
        Avion unAvion;
        private int totalCostoPasajes = 0;

        public Vuelo(int id, int duracionVuelo, eOrigen origen, eDestinos destino, DateTime horaDePartida, string nombrePiloto, string matriculaDeAvionAsignado, Avion unAvion, string estado)
        {
            this.id = id;
            this.duracionVuelo = duracionVuelo;
            this.origen = origen;
            this.destino = destino;
            this.horaDePartida = horaDePartida;
            this.nombrePiloto = nombrePiloto;
            this.matriculaDeAvionAsignado = matriculaDeAvionAsignado;
            this.unAvion = unAvion;
            this.estado = estado;
            this.capacidadDeAsientosPremium = unAvion.CantidadDeAsientosPremium;
            this.capacidadDeAsientosTurista = unAvion.CantidadDeAsientosTurista;
        }

        public Vuelo(int id, int duracionVuelo, eOrigen origen, eDestinos destino, DateTime horaDePartida, string nombrePiloto, string matriculaDeAvionAsignado,Avion unAvion, string estado, List<Pasajero> listaDePasajeros, int cantidadDeAsientosOcupados) : this (id, duracionVuelo, origen, destino, horaDePartida, nombrePiloto, matriculaDeAvionAsignado, unAvion, estado)
        {
            this.id = id;
            this.duracionVuelo = duracionVuelo;
            this.origen = origen;
            this.destino = destino;
            this.horaDePartida = horaDePartida;
            this.nombrePiloto = nombrePiloto;
            this.matriculaDeAvionAsignado = matriculaDeAvionAsignado;
            this.listaDePasajeros = listaDePasajeros;
            this.cantidadDeAsientosOcupados = cantidadDeAsientosOcupados;
            this.unAvion = unAvion;
            this.estado = estado;

            for (int i = 0; i < listaDePasajeros.Count; i++)
            {
                 this.totalCostoPasajes += listaDePasajeros[i].PrecioPasaje;
            }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public eOrigen Origen
        { 
            get { return origen; }
        }
        public eDestinos Destino
        {
            get { return destino; }
        } 

        public DateTime FechaYHoraDePartida
        { get { return horaDePartida; } }
        public int DuracionVuelo
        {
            get { return duracionVuelo; }
        }

        public string NombrePiloto
        {
            get { return nombrePiloto; }
        }

       public string MatriculaDeAvionAsignado
       {
            get { return matriculaDeAvionAsignado; }
       }

        public int CantidadDeAsientosDisponibles
        {
            get { return cantidadDeAsientosOcupados; }
            set { cantidadDeAsientosOcupados = value; }
            
        }

        public int CapacidadDeAsientosPremium
        {
            get { return capacidadDeAsientosPremium; }
            set { capacidadDeAsientosPremium = value; }
        }

        public int CapacidadDeAsientosTurista
        {
            get { return capacidadDeAsientosTurista; }
            set { capacidadDeAsientosTurista = value; }
        }



        public string Estado
            { get { return estado; } }

        public List<Pasajero> ListaPasajeros
        { get { return listaDePasajeros; } }
            
        public Avion UnAvion
            { 
            get { return unAvion; } 
            set { unAvion = value; }
        }

        public int TotalCostopasajes
        {
            get { return totalCostoPasajes; }
            set { totalCostoPasajes = value; }


        }

        public static Vuelo ObtenerVuelo(List<Vuelo> listaDeVuelos, int index)
        {
            if(listaDeVuelos is not null && index > -1)
            {
                return listaDeVuelos[index];
            }

            return null;

        }

        public bool AgregarPasajeroALista(Pasajero auxPasajero)
        {
            if (auxPasajero is not null)
            {
               this.listaDePasajeros.Add(auxPasajero);
               return true;
            }

            return false;

        }


        public int CalcularGananciasDeUnVuelo(Vuelo unVuelo)
        {
            int acumuladorGanancias = 0;

            for (int i = 0; i < unVuelo.listaDePasajeros.Count; i++)
            {
                acumuladorGanancias += unVuelo.listaDePasajeros[i].PrecioPasaje;

            }

            return acumuladorGanancias;
        }

        public static int OrdenarListaDeDestinosPorFacturacionDescente(Vuelo a, Vuelo b)
        {
            return (int)a.totalCostoPasajes - b.totalCostoPasajes;
        }


    }
}
