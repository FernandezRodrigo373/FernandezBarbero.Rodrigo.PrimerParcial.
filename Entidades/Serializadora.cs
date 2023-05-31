using Newtonsoft.Json;
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

    }
}
