using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    class Operaciones1
    {
        int[] arreglo;
        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public void LlenarArreglo(int tama)
        {
            arreglo = new int[tama];
            for (int i = 0; i < tama; i++)
            {
                arreglo[i] = i;
            }
        }

        public Boolean ImprimirArrglo()
        {
            if (arreglo != null)
            {
                int tama = arreglo.Length;
                for (int i = 0; i < arreglo.Length; i++)
                {
                    int indice = arreglo[i];
                    Console.WriteLine(tama);
                }
            }
            return false;
        }
    }
}
