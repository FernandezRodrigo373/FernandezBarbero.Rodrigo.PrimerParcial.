using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum eDestinos
    {
        BuenosAires,
        SantaRosa,
        Bariloche,
        Corrientes,
        Córdoba,
        Jujuy,
        Mendoza,
        Neuquén,
        Posadas,
        Iguazú,
        Salta,
        SantiagodelEstero,
        Trelew,
        Tucumán,
        PuertoMadryn,
        Ushuaia,
        Recife,
        Roma,
        Acapulco,
        Miami
    }


    public class Destino
    {
        private eDestinos destino = (eDestinos) 0;
        private static int facturacion = 0;

	
        public string DestinoElegido
        {
            get { return destino.ToString(); }
            
        }

        public static int Facturacion
            { get { return facturacion; } }
        
        public static eDestinos ObtenerDestino(eDestinos destino)
        {
            return destino;
        }




    }
}
