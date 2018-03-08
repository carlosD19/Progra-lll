using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Llamada
    {
        public int Duracion { get; set; }
        public int Costo { get; set; }

        public Llamada(int duracion)
        {
            if (ValidarNum(duracion))
            {
                Duracion = duracion;
                Costo = 5;
            }
        }
        public double CalcularCosto()
        {
            if (Duracion < 3)
            {
                return Costo;
            }
            Duracion -= 3;
            Costo = Costo + (Duracion * 3);
            return Costo;
        }

        public bool ValidarNum(int duracion)
        {
            return duracion > 0 && duracion % 1 == 0;
        }
    }
}
