using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor : Persona
    {
        private string nombreUsuario;
        private string clave;

       
        public Vendedor(string nombre, string apellido, int edad, string nombreUsuario, string clave) : base(nombre, apellido, edad)
        {
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
        }

        public string Usuario
        {
            get { return nombreUsuario; }
        } 

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public string Clave
        {
            get { return clave; }
        }

        public override string ToString()
        {
            return base.MostrarInfoPersona() + "Es el vendedor";
        }










    }
}
