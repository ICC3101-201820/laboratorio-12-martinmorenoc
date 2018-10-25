using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Modelo;

namespace MVC
{
    [Serializable()]
    class Controlador
    {
        public Form1 form1;
        private ListaComidas comidas;

        public Controlador()
        {
            if (File.Exists("comidas.bin"))
            {
                comidas = ListaComidas.Deserializar("comidas.bin");
            }
            else
            {
                comidas = new ListaComidas();
            }
        }

        public void OnAgregarComida(string nombre, int proteinas, int grasas, int carbohidratos)
        {
            Comida comida = new Comida(nombre, proteinas, grasas, carbohidratos);
            comidas.Agregar(comida);
            ListaComidas.Serializar("comidas.bin", comidas);
            form1.AgregarComida(comida);
    
        }

        public void OnEliminarComida(Comida comida)
        {
            comidas.Eliminar(comida);
            ListaComidas.Serializar("comidas.bin", comidas);
            form1.EliminarComida(comida);
            
        }
    }
}
