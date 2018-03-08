using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Automovil
    {
        public double Precio { get; set; }
        public double Impuesto { get; set; }
        public double Ganancia { get; set; }

        public Automovil(double auto)
        {
            Precio = auto;
            Impuesto = Precio * 0.06;
            Ganancia = Precio * 0.012;
            
        }
        public double CalcularPrecio()
        {
            return Precio + Impuesto + Ganancia;
        }
    }
}
