using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validadora
    {
        static Validadora()
        {

        }

        public static bool ValidarLetras(string cadenaAValidar)
        {
            Regex validar = new Regex(@"^[a-zA-Z]*$");

            if (validar.IsMatch(cadenaAValidar))
            {
                return true;
            }

            return false;
        }

        public static bool ValidarNumeroConRango(string stringATransoformar, double min, double max)
        {
            double auxNumero = 0;

            if (double.TryParse(stringATransoformar, out auxNumero) && min < max)
            {
                if (auxNumero >= min && auxNumero < max)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
