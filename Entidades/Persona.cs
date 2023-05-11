using System;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        protected Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public virtual string MostrarInfoPersona()
        {
            return $"{nombre} \n{apellido} \n{edad}\n";
        }

        
    }
}
