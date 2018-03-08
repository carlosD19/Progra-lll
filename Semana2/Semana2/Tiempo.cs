using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Tiempo
    {
        public int Dias { get; set; }

        public Tiempo(int dias)
        {
            Dias = dias;
        }

        public int CalcularSegundos()
        {
            return Dias * 24 * 60 *60;
        }
    }
}
