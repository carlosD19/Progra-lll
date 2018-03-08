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
            Operaciones1 operaciones = new Operaciones1();
            Boolean salir = false;
            while (true)
            {
                int num1 = 0;
                int num2 = 0;
                Console.WriteLine("1: Sumar.\n" +
                    "2: Restar.\n" +
                    "3: Multiplicación.\n" +
                    "4: División.\n" +
                    "5: LLenar Arreglo.\n" +
                    "6: Imprimir Arreglo.\n" +
                    "7: Salir del menú.");
                int opc = Int32.Parse(Console.ReadLine());
                if (opc == 1 || opc == 2 || opc == 3 || opc == 4)
                {
                    Console.WriteLine("ingrese el primer numero:");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = Int32.Parse(Console.ReadLine());
                }
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("El resultado es = " + operaciones.Sumar(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("El resultado es = " + operaciones.Restar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("El resultado es = " + operaciones.Multiplicar(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("El resultado es = " + operaciones.Dividir(num1, num2));
                        break;
                    case 5:
                        Console.WriteLine("Digite el tamaño del arreglo.");
                        int tamanoArreglo = Int32.Parse(Console.ReadLine());
                        operaciones.LlenarArreglo(tamanoArreglo);
                        break;
                    case 6:
                        if (!operaciones.ImprimirArrglo())
                        {
                            Console.WriteLine("Debes llenar el Arreglo antes.");
                            goto case 5;
                        }
                        operaciones.ImprimirArrglo();
                        break;
                    case 7:
                        salir = true;
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }
            }
    }
}
