using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Serializadora
    {

        static Serializadora()
        {

        }

        public static List<Avion> DeserializarAviones()
        {

            List<Avion> listaAviones;

            string jsonString = "aviones.json";

            string aux = File.ReadAllText(jsonString);

            listaAviones = JsonConvert.DeserializeObject<List<Avion>>(aux);
            

            return listaAviones;
        }

         public static List<Empleado> DeserializarEmpleados()
         {
            List <Empleado> listaEmpleados;
            string jsonString = "MOCK_DATA.json";

            string aux = File.ReadAllText(jsonString);

            listaEmpleados = JsonConvert.DeserializeObject<List<Empleado>>(aux);

            return listaEmpleados;
         }  



        public static List<Cliente> DeserializarClientes()
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();

            xRoot.ElementName = "Clientes";

            xRoot.IsNullable = true;

            using (StreamReader reader = new StreamReader("clientes.xml"))
            {
                List<Cliente> lista = (List<Cliente>)(new XmlSerializer(typeof(List<Cliente>), xRoot)).Deserialize(reader);
                
                return lista;
            }

        }

        public static void GuardarClientes(List<Cliente> listaClientes)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Cliente>));

            using (StreamWriter writer = new StreamWriter("clientes.xml"))
            {
                xmlSerializer.Serialize(writer, listaClientes);
            }
        }

    }
}
