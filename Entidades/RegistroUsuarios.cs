using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class RegistroUsuarios
    {

        public static void RegistrarAccesoUsuario(string nombreUsuario, string apellidoUsuario, string perfil)
        {
            string fechaHoraIngreso = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string mensaje = $" {fechaHoraIngreso} Usuario '{nombreUsuario +" " + apellidoUsuario }'( {perfil} ) ha accedido a la aplicación.\n";

            File.AppendAllText("usuarios.log", mensaje);

            //File.ReadAllText(arhivo);

        }

    }
}
