using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Gasolinera
    {
        public double Galones { get; set; }
        public double Precio { get; set; }
        public const  double GAL_LIT = 3.78;

        public Gasolinera()
        {
            Precio = 672;
            Galones = 5;
        }
        public double CalcularPrecio()
        {
            return (Galones * GAL_LIT) * Precio;
        }
    }
}
