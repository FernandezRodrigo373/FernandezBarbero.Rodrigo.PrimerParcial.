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
        private static string logFilePath = "usuarios.log"; 

        public static void RegistrarAccesoUsuario(string nombreUsuario, string apellidoUsuario)
        {
            string fechaHoraActual = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string mensaje = $"[{fechaHoraActual}] Usuario '{nombreUsuario + apellidoUsuario}' ha accedido a la aplicación.";

            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.WriteLine(mensaje);
            }
        }
        
    }
}
