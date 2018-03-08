using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosMartinezQuizLogicaInterfaz
{
    class ArregloUtilidades
    {

        internal String OrdenarArreglo()
        {
            string x = "";
            int[] num = {1,9,5,0};
            Array.Sort(num);
            for (int i = 0; i < num.Length; i++)
            {
                x += num[i] + ", ";
            }
            return x.Remove(x.Length-2);
        }
        internal string cadenaCaracteres(string p, int num1, int num2)
        {
            return p.Substring(num1-1, num2);
        }
        internal string promedio()
        {
            string x = "";
            int[] num = { 1, 9, 5, 10 };
            Array.Sort(num);
            int resultado = num[num.Length-1] - num[0];
            x = String.Format("El promedio es de {0}", resultado);
            return x;
        }
    }
}
