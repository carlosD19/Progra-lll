using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int inicio = 2;
            int resultado = 1;
            int a = 1;
            int b = 1;

            Console.Write("Primer numero: ");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.Write("Segundo numero: ");
            numero2 = Int32.Parse(Console.ReadLine());
            while (true)
            {
                if((numero1 % inicio == 0) && (numero2 % inicio == 0))
                {
                    resultado *= inicio;
                    a = numero1 / inicio;
                    b = numero2 / inicio;
                }
                else
                {
                    inicio++;
                }
                if (resultado * a == numero1 && resultado * b == numero2) { 

                }       
                {

                }
            }
            Console.WriteLine(resultado);
        }
    }
}
