using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int respuenta;
            Console.WriteLine("Primer numero:");
            int num1 = Int32.Parse(Console.ReadLine());            
            Console.WriteLine("Sengundo numero:");
            int num2 = Int32.Parse(Console.ReadLine());

            int max = Math.Max(num1, num2);
            int min = Math.Min(num1, num2);
            do
            {
                respuenta = min;
                min = max % min;
                max = respuenta;
            } while (min != 0);
            Console.WriteLine("El M.C.D entre {0} y {1}", num1, num2+" es: " + respuenta);
            Console.ReadKey(true);
        }
    }
}
