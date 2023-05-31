using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
//using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json;

namespace Entidades
{
    public static class AerolineaSistema 
    {
        public static List<Empleado> listaEmpleados;
        public static List<Vuelo> listaDeVuelos;
        public static List<Avion> listaDeAviones;
        public static List<Cliente> listaDeClientes;
        public static List<Pasajero> listaDePasajeros;
        public static Dictionary<string, int> clientesYaGanadores;


        static DateTime fecha1 = new DateTime(2022, 9, 25);
        static DateTime fecha2 = new DateTime(2022, 11, 8);
        static DateTime fecha3 = new DateTime(2022, 12, 16);
        static DateTime fecha4 = new DateTime(2022, 10, 29);
        static string mensaje1;
        static string mensaje2;
        static string mensaje3;




        static AerolineaSistema()
        {

            listaEmpleados = Serializadora.DeserializarEmpleados();
            listaDeAviones = Serializadora.DeserializarAviones();

            listaDeClientes = Serializadora.DeserializarClientes();



            // No puedo generar la deserializacion para vuelos debido a que no tengo los conocimientos para realizarla,
            // no se como se podria agregar los datos de otras clases dentro de un archivo xml
            // espero lo tengan en consideracion muchas gracias

            listaDeVuelos = new List<Vuelo>();
            mensaje1 = EstadoVuelo(listaDeAviones[0].CantidadDeAsientos, CargarPasajeros1().Count);
            mensaje2 = EstadoVuelo(listaDeAviones[2].CantidadDeAsientos, CargarPasajeros2().Count);
            mensaje3 = EstadoVuelo(listaDeAviones[3].CantidadDeAsientos, CargarPasajeros3().Count);

            listaDeVuelos.Add(new Vuelo(1, 2, eOrigen.Córdoba, eDestinos.Bariloche, fecha1, "Carlos", listaDeAviones[0].Matricula, listaDeAviones[0], mensaje1, CargarPasajeros1(), listaDeAviones[0].CantidadDeAsientos - CargarPasajeros1().Count));
            listaDeVuelos.Add(new Vuelo(2, 4, eOrigen.Jujuy, eDestinos.Recife, fecha2, "Juan", listaDeAviones[3].Matricula, listaDeAviones[3], mensaje3, CargarPasajeros2(), listaDeAviones[3].CantidadDeAsientos - CargarPasajeros2().Count));
            listaDeVuelos.Add(new Vuelo(3, 2, eOrigen.Mendoza, eDestinos.SantaRosa, fecha3, "Pepe", listaDeAviones[2].Matricula, listaDeAviones[2], mensaje2, CargarPasajeros3(), listaDeAviones[2].CantidadDeAsientos - CargarPasajeros3().Count));
            listaDeVuelos.Add(new Vuelo(4, 2, eOrigen.BuenosAires, eDestinos.SantaRosa, fecha4, "Jorge", listaDeAviones[0].Matricula, listaDeAviones[0], mensaje2, CargarPasajeros1(), listaDeAviones[0].CantidadDeAsientos - CargarPasajeros1().Count));

            clientesYaGanadores = new Dictionary<string, int>();

            clientesYaGanadores.Add("Manuel", 25012547);
            clientesYaGanadores.Add("Maria", 25145250);
            clientesYaGanadores.Add("Laura", 32012856);
            clientesYaGanadores.Add("Horacio", 24325452);
            clientesYaGanadores.Add("Esteban", 33147258);
            clientesYaGanadores.Add("Pedro", 24057102);
            clientesYaGanadores.Add("Andrea", 42257847);
            clientesYaGanadores.Add("Gustavo", 22145325);
        }


        /// <summary>
        /// Valida el ingreso de datos para el login de los empleados
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static Empleado ValidarLoginVendedores(string correo, string clave)
        {
            
           // if (!String.IsNullOrEmpty(clave))
           // {
                foreach (Empleado empleadoEnLista in listaEmpleados)
                {
                    if (empleadoEnLista.correo == correo)
                    {
                        if (empleadoEnLista.Clave == clave)
                        {
                            return empleadoEnLista;
                        }
                        //throw new Exception("ERROR. Clave incorrecta");
                    }
                }

            //}
            // throw new Exception("ERROR. Vuelva a ingresar los datos");
            return null;

        }



        public static List<Vuelo> CargarVuelos()
        {
            List<Vuelo> lista = new List<Vuelo>();

            foreach (Vuelo item in listaDeVuelos)
            {
                lista.Add(item);
            }

            return lista;

        }
        public static List<Avion> CargarAviones()
        {
            List<Avion> lista = new List<Avion>();

            foreach (Avion item in listaDeAviones)
            {
                lista.Add(item);
            }

            return lista;
        }

        public static List<Cliente> CargarClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            foreach (Cliente item in listaDeClientes)
            {
                lista.Add(item);
            }

            return lista;
        }    
        
        public static List<Cliente> BuscarClientePorNombre(string nombre)
        {
            List<Cliente> auxCliente = new List<Cliente>();

            if (!String.IsNullOrEmpty(nombre))
            {
                foreach (Cliente item in listaDeClientes)
                {
                    if (item.Nombre.Contains(nombre))
                    {
                        auxCliente.Add(item);
                    }

                }
            }
            return auxCliente;
        }   
        public static List<Cliente> BuscarClientePorDni(int dni)
        {
            List<Cliente> auxCliente = new List<Cliente>();

            if (Validadora.ValidarNumeroConRango(dni.ToString(), 10000, 300000000))
            {
                foreach (Cliente item in listaDeClientes)
                {
                    if (item.Dni.Equals(dni))
                    {
                        auxCliente.Add(item);
                    }

                }
            }
            return auxCliente;
        }

        /// <summary>
        /// Setea el estado del vuelo con disponible o completo
        /// </summary>
        /// <param name="cantidadDeAsientos"></param>
        /// <param name="cantidadDePasajeros"></param>
        /// <returns></returns>
        public static string EstadoVuelo(int cantidadDeAsientos, int cantidadDePasajeros)
        {
            string mensaje = " ";

            if (cantidadDePasajeros > -1)
            {

                if (cantidadDeAsientos == cantidadDePasajeros)
                {
                    mensaje = "Completo";

                }
                else if (cantidadDeAsientos > cantidadDePasajeros)
                {
                    mensaje = "Disponible";
                }
            }
            return mensaje;
        }

        /// <summary>
        /// Busca el vuelo por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Vuelo> BuscarVuelo(int id)
        {
            List<Vuelo> auxVuelo = new List<Vuelo>();

            foreach (Vuelo item in listaDeVuelos)
            {
                if (item.Id == id)
                {
                    auxVuelo.Add(item);
                }

            }

            return auxVuelo;
        }

        public static List<Avion> BuscarAvion(string matricula)
        {
            List<Avion> auxVuelo = new List<Avion>();

            foreach (Avion item in listaDeAviones)
            {
                if (item.Matricula == matricula)
                {
                    auxVuelo.Add(item);
                }

            }

            return auxVuelo;
        }

        public static List<Pasajero> CargarPasajeros1()
        {
            List<Pasajero> lista = new List<Pasajero>();

            lista.Add(new Pasajero( listaDeClientes[0].Nombre, listaDeClientes[0].Apellido,  25, eEquipaje.deMano, eEquipaje.deBodega, eClase.premium, 119, 30));
            lista.Add(new Pasajero( listaDeClientes[1].Nombre, listaDeClientes[1].Apellido, 19, eEquipaje.deMano, eEquipaje.deBodega, eClase.premium, 120, 40));
            lista.Add(new Pasajero( listaDeClientes[2].Nombre, listaDeClientes[2].Apellido, 20, eEquipaje.deMano, eEquipaje.deBodega, eClase.turista, 108, 15));
            lista.Add(new Pasajero( listaDeClientes[3].Nombre, listaDeClientes[3].Apellido, 78, eEquipaje.deMano, eEquipaje.deBodega, eClase.turista, 102, 22));

            return lista;
          

        }

        public static List<Pasajero> CargarPasajeros2()
        {
            List<Pasajero> lista = new List<Pasajero>();

            lista.Add(new Pasajero( listaDeClientes[4].Nombre, listaDeClientes[4].Apellido, 38, eEquipaje.deMano, eEquipaje.deBodega, eClase.premium, 100, 30));
            lista.Add(new Pasajero( listaDeClientes[5].Nombre, listaDeClientes[5].Apellido, 50, eEquipaje.deMano, eEquipaje.deBodega, eClase.premium, 120, 40));
            lista.Add(new Pasajero( listaDeClientes[6].Nombre, listaDeClientes[6].Apellido, 43, eEquipaje.deMano, eEquipaje.deBodega, eClase.turista, 109, 25));
            lista.Add(new Pasajero( listaDeClientes[7].Nombre, listaDeClientes[7].Apellido, 47, eEquipaje.deMano, eEquipaje.deBodega, eClase.turista, 105, 18));

            return lista;
        }    
        
        public static List<Pasajero> CargarPasajeros3()
        {
            List<Pasajero> lista = new List<Pasajero>();

            lista.Add(new Pasajero( listaDeClientes[8].Nombre, listaDeClientes[8].Apellido, 14, eEquipaje.deMano, eEquipaje.deBodega, eClase.turista, 105, 15));
            lista.Add(new Pasajero( listaDeClientes[9].Nombre, listaDeClientes[9].Apellido, 12, eEquipaje.deMano, eEquipaje.deBodega, eClase.turista, 106, 18));
            lista.Add(new Pasajero( listaDeClientes[10].Nombre, listaDeClientes[10].Apellido, 53, eEquipaje.deMano, eEquipaje.deBodega, eClase.premium, 110, 29));

            return lista;
        }

        /// <summary>
        /// Muestra el destino mas elegido por los pasajeros
        /// </summary>
        /// <param name="Vuelos"></param>
        /// <returns></returns>
        public static string MostrarDestinosMasElegido(List<Vuelo> Vuelos)
        {
            eDestinos destinoMasElegido;

            int destinoMasElegidoContador = 0;
            int destinoMasElegidoIndice = 0;
            int flag = 0;         

            List<int> contadorDestinoMasElegido = new List<int>();

            int contBsAs = 0;
            int contSantaRosa = 0;
            int contBariloche = 0;
            int contCorrientes = 0;
            int contCordoba = 0;
            int contJujuy = 0;
            int contMendoza = 0;
            int contNeuquen = 0;
            int contPosadas = 0;
            int contIguazu = 0;
            int contSalta = 0;
            int contSdE = 0;
            int contTrelew = 0;
            int contTucuman = 0;
            int contPuertoM = 0;
            int contUshuaia = 0;
            int contRecife = 0;
            int contRoma = 0;
            int contAcapulco = 0;
            int contMiami = 0;        
              

            for (int i = 0; i < Vuelos.Count; i++)
            {
                switch (Vuelos[i].Destino)
                {
                    case eDestinos.BuenosAires:
                        contBsAs++;
                        break;
                    case eDestinos.SantaRosa:
                        contSantaRosa++;
                        break;
                    case eDestinos.Bariloche:
                        contBariloche++;
                        break;
                    case eDestinos.Corrientes:
                        contCorrientes++;
                        break;
                    case eDestinos.Córdoba:
                        contCordoba++;
                        break;
                    case eDestinos.Jujuy:
                        contJujuy++;
                        break;
                    case eDestinos.Mendoza:
                        contMendoza++;
                        break;
                    case eDestinos.Neuquén:
                        contNeuquen++;
                        break;
                    case eDestinos.Posadas:
                        contPosadas++;
                        break;
                    case eDestinos.Iguazú:
                        contIguazu++;
                        break;
                    case eDestinos.Salta:
                        contSalta++;
                        break;
                    case eDestinos.SantiagodelEstero:
                        contSdE++;
                        break;
                    case eDestinos.Trelew:
                        contTrelew++;
                        break;
                    case eDestinos.Tucumán:
                        contTucuman++;
                        break;
                    case eDestinos.PuertoMadryn:
                        contPuertoM++;
                        break;
                    case eDestinos.Ushuaia:
                        contUshuaia++;
                        break;
                    case eDestinos.Recife:
                        contRecife++;
                        break;
                    case eDestinos.Roma:
                        contRoma++;
                        break;
                    case eDestinos.Acapulco:
                        contAcapulco++;
                        break;
                    default:
                        contMiami++;
                        break;
                }


            }

            contadorDestinoMasElegido.Add(contBsAs);
            contadorDestinoMasElegido.Add(contSantaRosa);
            contadorDestinoMasElegido.Add(contBariloche);
            contadorDestinoMasElegido.Add(contCorrientes);
            contadorDestinoMasElegido.Add(contCordoba);
            contadorDestinoMasElegido.Add(contJujuy);
            contadorDestinoMasElegido.Add(contMendoza);
            contadorDestinoMasElegido.Add(contNeuquen);
            contadorDestinoMasElegido.Add(contPosadas);
            contadorDestinoMasElegido.Add(contIguazu);
            contadorDestinoMasElegido.Add(contSalta);
            contadorDestinoMasElegido.Add(contSdE);
            contadorDestinoMasElegido.Add(contTrelew);
            contadorDestinoMasElegido.Add(contTucuman);
            contadorDestinoMasElegido.Add(contPuertoM);
            contadorDestinoMasElegido.Add(contUshuaia);
            contadorDestinoMasElegido.Add(contRecife);
            contadorDestinoMasElegido.Add(contRoma);
            contadorDestinoMasElegido.Add(contAcapulco);
            contadorDestinoMasElegido.Add(contMiami);

            for (int i = 0; i < contadorDestinoMasElegido.Count; i++)
            {
                if (flag == 0 || contadorDestinoMasElegido[i] > destinoMasElegidoContador)
                {
                    destinoMasElegidoContador = contadorDestinoMasElegido[i];
                    destinoMasElegidoIndice = i;
                    flag = 1;
                }
            }


            switch(destinoMasElegidoIndice)
            {
                case 0:
                    destinoMasElegido = eDestinos.BuenosAires;
                    break;
                case 1:
                    destinoMasElegido = eDestinos.SantaRosa;
                    break;
                case 2:
                    destinoMasElegido = eDestinos.Bariloche;
                    break;
                case 3:
                    destinoMasElegido = eDestinos.Corrientes;
                    break;
                case 4:
                    destinoMasElegido = eDestinos.Córdoba;
                    break;
                case 5:
                    destinoMasElegido = eDestinos.Jujuy;
                    break;
                case 6:
                    destinoMasElegido = eDestinos.Mendoza;
                    break;
                case 7:
                    destinoMasElegido = eDestinos.Neuquén;
                    break;
                case 8:
                    destinoMasElegido = eDestinos.Posadas;
                    break;
                case 9:
                    destinoMasElegido = eDestinos.Iguazú;
                    break;
                case 10:
                    destinoMasElegido = eDestinos.Salta;
                    break;
                case 11:
                    destinoMasElegido = eDestinos.SantiagodelEstero;
                    break;
                case 12:
                    destinoMasElegido = eDestinos.Trelew;
                    break;
                case 13:
                    destinoMasElegido = eDestinos.Tucumán;
                    break;
                case 14:
                    destinoMasElegido = eDestinos.PuertoMadryn;
                    break;
                case 15:
                    destinoMasElegido = eDestinos.Ushuaia;
                    break;
                case 16:
                    destinoMasElegido = eDestinos.Recife;
                    break;
                case 17:
                    destinoMasElegido = eDestinos.Roma;
                    break;
                case 18:
                    destinoMasElegido = eDestinos.Acapulco;
                    break;
                default:
                    destinoMasElegido = eDestinos.Miami;
                    break;

            }


            return destinoMasElegido.ToString();
        }


        public static int ObtenerGananciasTotales( List<Vuelo> vuelos)
        {
            int ganancia = 0;

            for (int i = 0; i < vuelos.Count; i++)
            {
                for (int j = 0; j < vuelos[i].ListaPasajeros.Count; j++)
                {
                    ganancia += vuelos[i].ListaPasajeros[j].PrecioPasaje;
                }
             
            }
            return ganancia;
        }    
        
        public static int ObtenerGananciasInternacional(List<Vuelo> vuelos)
        {
            int ganancia = 0;
            for (int i = 0; i < vuelos.Count; i++)
            {
                if (vuelos[i].Destino == eDestinos.Recife || vuelos[i].Destino == eDestinos.Roma || vuelos[i].Destino == eDestinos.Acapulco || vuelos[i].Destino == eDestinos.Miami)
                {
                  
                    for (int j = 0; j < vuelos[i].ListaPasajeros.Count; j++)
                    {
                        ganancia += vuelos[i].ListaPasajeros[j].PrecioPasaje;
                    }

                }
            }
            return ganancia;

        }   
        
        public static int ObtenerGananciasNacional(List<Vuelo> vuelos)
        {
            int ganancia = 0;
            for (int i = 0; i < vuelos.Count; i++)
            {
                if (vuelos[i].Destino != eDestinos.Recife && vuelos[i].Destino != eDestinos.Roma && vuelos[i].Destino != eDestinos.Acapulco && vuelos[i].Destino != eDestinos.Miami)
                {           
                    for (int j = 0; j < vuelos[i].ListaPasajeros.Count; j++)
                    {
                       ganancia += vuelos[i].ListaPasajeros[j].PrecioPasaje;
                    }

                }
            }
            return ganancia;

            
        }

        public static int CalcularGanancias(int ganancia)
        {
            int acum = 0;

            if (ganancia > -1)
            { 
                return acum += ganancia;
            }
            return 0;
        }

        public static void AumentarHorasDeVuelos(List<Vuelo> vuelos)
        {
            foreach (Avion item in listaDeAviones)
            {
                item.CalcularHorasDeVuelo(vuelos);
            }
        }

    }
}
