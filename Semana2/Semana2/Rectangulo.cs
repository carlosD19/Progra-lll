using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Rectangulo
    {
        public double Largo { get; internal set; }
        public int Ancho { get; internal set; }

        internal double CalcularArea()
        {
            return Largo * Ancho;
        }
        internal double CalcularTiempo(double pared, double ventana)
        {
            double metros = pared - ventana;
            return metros * 10;
        }
    }
}
