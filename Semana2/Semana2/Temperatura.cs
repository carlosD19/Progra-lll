using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Temperatura
    {
        public double Grados { get; set; }

        internal double CalcularGrados ()
        {
            return Grados * 9 / 5 + 32;
        }
    }
}
