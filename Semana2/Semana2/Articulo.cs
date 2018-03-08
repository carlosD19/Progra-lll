using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Articulo
    {
        
        public int Clave { get; set; }
        public string Desc { get; set; }
        public double Precio { get; set; }
        public int Cant { get; set; }

        public Articulo(int v1, string v2, int v3, int v4)
        {
            this.Clave = v1;
            this.Desc = v2;
            this.Precio = v3;
            this.Cant = v4;
        }
        public double CalcularIVA()
        {
            return Precio * 0.5;
        }
    }
}
