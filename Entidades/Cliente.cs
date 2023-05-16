using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private int dni;
        private int cantidadDeVuelos;


        public Cliente(string nombre, string apellido, int edad, int dni, int cantidadDeVuelos) : base(nombre, apellido, edad)
        {
            this.dni = dni;
            this.cantidadDeVuelos = cantidadDeVuelos;
        }

        public int Dni { get { return dni; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Edad 
        {
            get
            { 
                return edad;
            }
            set { Edad = value; }
        }


        public static Cliente ObtenerCliente(List<Cliente> listaDeClientes, int index)
        {
            Cliente cliente = null;

            if(listaDeClientes is not null)
            {
                 cliente = listaDeClientes[index];
            }

            return cliente;

        }

        public int CantidadDeVuelos
        {
            get { return cantidadDeVuelos; }
            set { cantidadDeVuelos = value; }
        }

        public override string ToString()
        {
            return base.MostrarInfoPersona() + "Es el cliente";
        }

        public override bool Equals(object obj)
        {
            Cliente cliente = obj as Cliente;

            return cliente is not null && EsElMismoCliente(cliente, this);
        }  
        
        public override int GetHashCode()
        {
            return (nombre, apellido).GetHashCode();
        }

        public bool EsElMismoCliente(Cliente a, Cliente b)
        {
            return a.Dni == b.Dni && a.GetHashCode() != b.GetHashCode();
        }

        public static bool ClienteExisteEnLista(Cliente c)
        {
            foreach (Cliente item in AerolineaSistema.listaDeClientes)
            {
                if(item.Equals(c))
                {
                    
                    return true;
                }
            }
            return false;
        }

        public static string ClienteExisteEnLista(Cliente c, string dato)
        {
            foreach (Cliente item in AerolineaSistema.listaDeClientes)
            {
                if (item.Equals(c))
                {

                    return item.ToString() + dato;
                }
            }
            return null;
        }

        public static int OrdenarListaDeClienteDescente(Cliente a, Cliente b)
        {
            return (int)a.CantidadDeVuelos - b.CantidadDeVuelos;
        }      
        
        public static int OrdenarListaDeClienteAscendente(Cliente a, Cliente b)
        {
            return (int)b.CantidadDeVuelos - a.CantidadDeVuelos;
        }



    }
}
