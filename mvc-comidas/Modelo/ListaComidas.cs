using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Modelo
{
    [Serializable()]
    public class ListaComidas
    {
        List<Comida> comidas;

        public ListaComidas()
        {
            comidas = new List<Comida>();
        }

        public void Agregar(Comida comida)
        {
            comidas.Add(comida);
        }
        public void Eliminar(Comida comida)
        {
            comidas.Remove(comida);
        }

        public static void Serializar(string nombreArchivo, ListaComidas lista)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(nombreArchivo, FileMode.OpenOrCreate);
            binaryFormatter.Serialize(fileStream, lista);
            fileStream.Close();
        }

        public static ListaComidas Deserializar(string nombreArchivo)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(nombreArchivo, FileMode.Open);
            ListaComidas lista = (ListaComidas)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return lista;
        }
    }
}
