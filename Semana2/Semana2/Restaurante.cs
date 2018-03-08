using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Restaurante
    {
        public double Sencilla { get; set; }
        public double Queso { get; set; }
        public double Especial { get; set; }
        public double Papas { get; set; }
        public double Refresco { get; set; }
        public double Postre { get; set; }

        public Restaurante(int sen, int queso, int esp, int papas, int refresco, int postre)
        {
            if(sen != 0) {
            Sencilla = 15 * sen;
            }
            if (queso != 0)
            {
                Queso = 18 * queso;
            }
            if (esp != 0)
            {
                Especial = 20 * esp;
            }
            if (papas != 0)
            {
                Papas = 8 * papas;
            }
            if (refresco != 0)
            {
                Refresco = 5 * refresco;
            }
            if (postre != 0)
            {
                Postre = 6 * postre;
            }
        }

        public double CalcularCuenta()
        {
            return Sencilla + Queso + Especial + Papas + Refresco + Postre;
        }
        public string CalcularOrden()
        {
            string resultado = "";

            if (Sencilla != 0)
            {
                resultado += (Sencilla / 15) + " Hamburguesa Sencilla.\n";
            }
            if (Queso != 0)
            {
                resultado += (Queso / 18) + " Hamburguesa con Queso.\n";
            }
            if (Especial != 0)
            { 
                resultado += (Especial / 20) + " Hamburguesa Especial.\n";
            }
            if (Papas != 0)
            {
                resultado += (Papas / 8) + " Papas.\n";
            }
            if (Refresco != 0)
            {
                resultado += (Refresco / 5) + " Refresco.\n";
            }
            if (Postre != 0)
            {
                resultado += (Postre / 6) + " Postre.\n";
            }
            return resultado;
        }
    }
}
