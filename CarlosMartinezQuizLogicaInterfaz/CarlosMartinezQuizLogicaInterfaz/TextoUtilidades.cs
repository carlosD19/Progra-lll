using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosMartinezQuizLogicaInterfaz
{
    class TextoUtilidades
    {
        internal string verificarPalabra(string p)
        {
            string palabra = "";
            for (int i = p.Length; i > 0; i--)
            {
                palabra += p[i-1];
            }
            if (palabra.Equals(p))
            {
                palabra = String.Format("La palabra ''{0}'' si es políndroma", p);
            }
            else
            {
                palabra = String.Format("La palabra ''{0}'' no es políndroma", p);
            }
            return palabra;
        }
    }
}
