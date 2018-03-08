using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosMartinezQuizLogicaInterfaz
{
    class NumeroUtilidades
    {
        internal String verificarNumero(int x)
        {
            string num = "";
            string cant = x.ToString().Length.ToString();
            string orig = x.ToString();
            double resultado = 0;
            for (int i = 0; i < Int32.Parse(cant); i++)
            {
                string temp = orig[i].ToString();
                resultado += Math.Pow(Int32.Parse(temp), Int32.Parse(cant));
            }
            if (x == resultado)
            {
                num = String.Format("El numero {0} si es Narcisista", x);
            }
            else
            {
                num = String.Format("El numero {0} no es Narcisista" , x);
            }
            return num;
        }
    }
}
