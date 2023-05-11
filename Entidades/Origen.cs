using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum eOrigen
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

    public  class Origen
    {
        private eOrigen origen = (eOrigen)0;

        public string DestinoElegido
        {
            get { return origen.ToString(); }

        }
    }
}
