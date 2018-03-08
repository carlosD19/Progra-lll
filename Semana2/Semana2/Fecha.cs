using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2
{
    class Fecha
    {
        public int Dia { get; private set; }
        public int Mes { get; private set; }
        public int Anno { get; private set; }

        public Fecha()
        {
            Dia = 4;
            Mes = 3;
            Anno = 2131;
        }

        public Fecha(int dia, int mes, int anno)
        {
            if (ValidarFecha(dia, mes, anno))
            {
                Dia = dia;
                Mes = mes;
                Anno = anno;
            }
            else
            {
                Dia = 4;
                Mes = 3;
                Anno = 2131;
            }
        }

        public bool ValidarFecha(int dia, int mes, int anno)
        {
            if (dia < 1 || dia > 31)
            {
                return false;
            }
            if (mes < 1 || mes > 12)
            {
                return false;
            }
            if (anno < 0)
            {
                return false;
            }
            if (dia > 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            {
                return false;
            }
            if (mes == 2 && dia > 28 && !EsBisiesto(anno))
            {

            }
            return true;
        }

        private bool EsBisiesto(int anno)
        {
            if (anno % 4 == 0)
            {
                if (anno % 100 == 0)
                {
                    return anno % 400 == 0;
                }
                return true;
            }
            return false;
        }

        internal string MostrarFecha()
        {
            return String.Format("{0}\\{1}\\{2}", Dia, Mes, Anno);
        }

        public void ModificarFecha(int dia, int mes, int anno)
        {
            if (ValidarFecha(dia, mes, anno))
            {
                Dia = dia;
                Mes = mes;
                Anno = anno;
            }
            else
            {
                Dia = 4;
                Mes = 3;
                Anno = 2131;
            }
        }
        internal string MostrarFecha2()
        {
            if (Dia < 10 && Mes < 10)
            {
                return String.Format("0{0}\\0{1}\\{2}", Dia, Mes, Anno);
            }
            if (Dia < 10 && Mes > 10)
            {
                return String.Format("0{0}\\{1}\\{2}", Dia, Mes, Anno);
            }
            if (Dia > 10 && Mes < 10)
            {
                return String.Format("{0}\\0{1}\\{2}", Dia, Mes, Anno);
            }
            return String.Format("{0}\\{1}\\{2}", Dia, Mes, Anno);
        }

        internal string MostrarFechaL()
        {
            EMes mes = (EMes)Mes;
            return String.Format("{0} de {1} de {2}", Dia, mes, Anno);
        }

    }
}
