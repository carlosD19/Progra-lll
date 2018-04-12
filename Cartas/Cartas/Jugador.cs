using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public Card[] Cartas { get; set; }

        public int Contar(Card[] c)
        {
            int total = 0;
            for (int i = 0; i < c.Length; i++)
            {
                switch (c[i].value)
                {
                    case "KING":
                        total += 10;
                        break;
                    case "ACE":
                        total += 11;
                        break;
                    case "JACK":
                        total += 10;
                        break;
                    case "QUEEN":
                        total += 10;
                        break;
                    default:
                        total += Int32.Parse(c[i].value);
                        break;
                }
            }
            return total;
        }
    }
}
