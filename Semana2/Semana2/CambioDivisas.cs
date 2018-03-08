using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class CambioDivisas
    {
        public double Colones { get; set; }
        public double TipoCambio { get; set; }

        public CambioDivisas(double tc)       
        {
            TipoCambio = tc;
        }
        public double ConvertirADolar()
        {
            return Colones / TipoCambio;
        }
    }
}
