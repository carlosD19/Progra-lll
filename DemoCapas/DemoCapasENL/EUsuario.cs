using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DemoCapasENL
{
    public class EUsuario
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoUno { get; set; }
        public string ApellidoDos { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Image Imagen { get; set; }
    }
}
