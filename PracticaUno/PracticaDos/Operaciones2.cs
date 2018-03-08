using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos
{
    class Operaciones2
    {
        public void Opciones()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Eliga su Opción.\n" +
                    "1: Saludar.\n" +
                    "2: Ingreso de 3 números.\n" +
                    "3: Invertir\n" +
                    "4: Menor digito\n" +
                    "5: Mayor digito\n" +
                    "6: Media del digito\n" +
                    "7: Salir del menú.");
                int opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Ingrese su Nombre.");
                        string nombre = Console.ReadLine();
                        Saludar(nombre);
                        break;
                    case 2:
                        while (true)
                        {
                            int num1 = LeerIn("Ingrese el primer numero.");
                            int num2 = LeerIn("Ingrese el segundo numero.");
                            int num3 = LeerIn("Ingrese el tercer numero.");
                            Console.WriteLine(Numeros(num1, num2, num3));
                            Console.WriteLine("s: Salir, otra para repetir.");
                            char con = Console.ReadKey().KeyChar;
                            if (con == 's')
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        int num = LeerIn("Digite un número positivo:");
                        Console.WriteLine("{0}--->{1}", num, InvertirNumero(num));
                        Console.ReadKey();
                        break;
                    case 4:
                        int cant = LeerIn("Digite la cantidad de numeros:");
                        int[] arreglo = new int[cant];
                        for (int i = 0; i < arreglo.Length; i++)
                        {
                            arreglo[i] = LeerIn("Digite el numero:" + (i + i));
                        }
                        //Console.WriteLine("El menor es {0}", Menor(arreglo[]));
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        public void Saludar(String nombre)
        {
            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Buenas tardes señor(a)" + nombre + " Hoy es: " + fecha);
        }
        public int Numeros(int num1, int num2, int num3)
        {
            /**if(num1 >= 0)
            {
                return  num2 * num;
            }
            else
            {
                return num2 + num3;
            }
            **/
            return num1 >= 0 ? num2 * num3 : num2 + num3;
        }
        public static int LeerIn(string mensaje)
        {
            int n1;
            do
            {
                Console.Write(mensaje + ": ");
            } while (!Int32.TryParse(Console.ReadLine(), out n1));
            return n1;
        }
        public int InvertirNumero(int num)
        {
            int inv = 0;
            while (num != 0)
            {
                int ult = num % 10;
                inv = inv * 10 + ult;
                num /= 10;
            }
            return inv;
        }
        public int Menor(int[] arreglo)
        {
            int menor = arreglo[0];
            foreach (var item in arreglo)
            {
                if (item < menor)
                {
                    menor = item;
                }

            }
            return menor;
        }
        public int Mayor(int[] arreglo)
        {
            int mayor = arreglo[0];
            foreach (var item in arreglo)
            {
                if (item > mayor)
                {
                    mayor = item;
                }

            }
            return mayor;
        }
    
}
}
