using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, n, i, aux;
            Console.WriteLine("¿Cantidad de meses?");
            n = int.Parse(Console.ReadLine());
            a = 0;
            b = 1; 
            for (i = 0; i < n+1; i++)
            {
                aux = a;
                a = b;
                b = aux + a; 
            }
            Console.WriteLine("La cantidad de parejas es de {0}", a);
            Console.ReadKey(); 
        }
    }
}
