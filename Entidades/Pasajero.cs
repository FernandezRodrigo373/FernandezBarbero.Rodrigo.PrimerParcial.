using System.Collections.Generic;

namespace Entidades
{
    public enum eEquipaje
    {
        deMano,
        deBodega,
        sinEquipaje
    } 
    
    public enum eClase
    {
        turista,
        premium
    }

    public class Pasajero : Persona
    {
        private eEquipaje equipaje1 = (eEquipaje)0;
        private eEquipaje equipaje2 = (eEquipaje)0;
        private eClase clase = (eClase)0;
        private int precioPasaje;
        private int pesoValijas;





        public Pasajero(string nombre, string apellido, int edad, eEquipaje equipaje1, eEquipaje equipaje2, eClase clase, int precioPasaje, int pesoValijas) : base( nombre, apellido, edad)
        {
            this.equipaje1 = equipaje1;
            this.equipaje2 = equipaje2;
            this.clase = clase;
            this.precioPasaje = precioPasaje;
            this.pesoValijas = pesoValijas;
            
        }     
        
        public Pasajero(Cliente cliente, eEquipaje equipaje1, eEquipaje equipaje2, eClase clase, int precioPasaje, int pesoValijas) : this(cliente.Nombre, cliente.Apellido,  cliente.Edad,  equipaje1,  equipaje2,  clase,  precioPasaje,  pesoValijas)
        {

        }   

        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int Edad { get { return edad; } }
        public eEquipaje Equipaje1 { get { return equipaje1; } }
        public eEquipaje Equipaje2 { get { return equipaje2; } }
        public string Clase
        { get { return clase.ToString(); }}



        public int PesoValijaEnKg { get { return pesoValijas; } }

        public int PrecioPasaje
        {
            get { return precioPasaje; }
            set { precioPasaje = value; }
        }


        public override bool Equals(object obj)
        {
            Pasajero pasajero = obj as Pasajero;

            return pasajero is not null && EsElMismoPasajero(pasajero, this);
        }

        public override int GetHashCode()
        {
            return (nombre, apellido).GetHashCode();
        }

        public bool EsElMismoPasajero(Pasajero a, Pasajero b)
        {
            return a.apellido == b.apellido && a.GetHashCode() != b.GetHashCode();
        }

        public static bool ConfirmarSiPasajeroExisteEnVuelo(Pasajero unPasajero, Vuelo unVuelo)
        {

            if (unVuelo.ListaPasajeros.Contains(unPasajero))
            {
                return true;
            }

            
            return false;
        }


    }
}
