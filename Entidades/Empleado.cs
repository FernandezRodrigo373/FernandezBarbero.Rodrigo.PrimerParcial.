using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {

        private string clave;
        private string perfil;
        public int legajo;
        public string correo;

       
        public Empleado( string apellido, string nombre, int legajo,string correo,  string clave, string perfil) : base(nombre, apellido)
        {
            this.correo = correo;
            this.clave = clave;
            this.perfil = perfil;
            this.legajo = legajo;
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }

        }

        public string Clave
        {
            get { return clave; }
            set
            {
                clave = value;
            }
        }

        public string Perfil
        {
            get { return perfil; }
            set
            {
                perfil = value;
            }
        }

        public int Legajo
        {
            get { return legajo; }
            set
            {
                legajo = value;
            }
        }
        public string Correo
        {
            get { return correo; }
            set
            {
                correo = value;
            }
        }

        public override string ToString()
        {
            return base.MostrarInfoPersona() + "Es el vendedor";
        }










    }
}
