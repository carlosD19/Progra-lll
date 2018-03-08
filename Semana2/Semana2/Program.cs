using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practica 2


            Console.WriteLine("RECTANGULO.");
            Console.WriteLine();
            Rectangulo pared = new Rectangulo { Largo = 7, Ancho = 5 };
            Rectangulo ventana = new Rectangulo { Largo = 3, Ancho = 2 };
            double area = (pared.CalcularArea() - ventana.CalcularArea()) * 10;
            Console.WriteLine("Area: " + area);
            double min = area * 10;
            int horas = (int)min / 60;
            int m = (int)min % 60;
            Console.WriteLine("Se tardará: {0} horas y {1} minutos", horas, m);
            Console.WriteLine();
            Console.WriteLine("FECHA.");
            Console.WriteLine();
            Fecha fec = new Fecha(1, 2, 1999);
            Console.WriteLine(fec.MostrarFecha());
            Console.WriteLine(fec.MostrarFecha2());
            Console.WriteLine(fec.MostrarFechaL());
            Console.WriteLine();
            Console.WriteLine("ARTICULO.");
            Console.WriteLine();
            Articulo art = new Articulo(1, "Azucar", 2030, 58);
            Console.WriteLine("El articulo: {0} paga {1} de IVA en CRC.", art.Desc, art.CalcularIVA());
            Console.WriteLine();
            Console.WriteLine("TEMPERATURA.");
            Console.WriteLine();
            Temperatura temp = new Temperatura { Grados = 30 };
            Console.WriteLine("{0}C son {1}F", temp.Grados, temp.CalcularGrados());
            Console.WriteLine();
            Console.WriteLine("CAMBIO DIVISAS.");
            Console.WriteLine();
            CambioDivisas cd = new CambioDivisas(568.18)
            {
                Colones = 100000
            };
            Console.WriteLine("{0} colones equivalen a {1:0.00} dolares.", cd.Colones, cd.ConvertirADolar());
            Console.WriteLine();
            Console.WriteLine("GASOLINERA.");
            Console.WriteLine();
            Gasolinera gs = new Gasolinera();
            Console.WriteLine("El cliente debe pagar {0} colones por los {1} galones", gs.CalcularPrecio(), gs.Galones);
            Console.WriteLine();
            Console.WriteLine("RESTAURANTE.");
            Console.WriteLine();
            Restaurante rs = new Restaurante(5, 0, 0, 2, 0, 1);
            Console.WriteLine(rs.CalcularOrden());
            Console.WriteLine("Cuenta por pagar: " + rs.CalcularCuenta() + " $");
            Console.WriteLine();
            Console.WriteLine("AUTOMOVIL.");
            Console.WriteLine();
            Automovil au = new Automovil(7000000);
            Console.WriteLine("Precio Original {0} - Precio Total {1}", au.Precio, au.CalcularPrecio());
            Console.WriteLine();
            Console.WriteLine("SEGUNDOS.");
            Console.WriteLine();
            Tiempo sg = new Tiempo(2);
            Console.WriteLine("En {0} dias hay {1} segundos.", sg.Dias, sg.CalcularSegundos());
            Console.WriteLine();
            Console.WriteLine("LLAMADA.");
            Console.WriteLine();
            Llamada llamada = new Llamada(5);
            Console.WriteLine("El costo de la llamada es de {0} $", llamada.CalcularCosto());
            Console.ReadKey();
            #endregion
        }
    }
}
