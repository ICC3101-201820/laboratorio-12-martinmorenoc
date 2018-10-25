using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    [Serializable()]
    public class Comida
    {
        string nombre;
        int proteinas;
        int grasas;
        int carbohidratos;

        public Comida(string n, int p, int g, int c)
        {
            nombre = n;
            proteinas = p;
            grasas = g;
            carbohidratos = c;
        }

        public int Calorias()
        {
            return (4 * carbohidratos + 4 * proteinas + 9 * grasas);
        }
        public override string ToString()
        {
            return $"{nombre} (carbohidratos: {carbohidratos}, proteinas: {proteinas}, grasas: {grasas}, calorias: {Calorias()})";
        }
    }
}
