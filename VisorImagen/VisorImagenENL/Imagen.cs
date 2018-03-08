using System;
using System.Drawing;

namespace VisorImagenENL
{
    public class Imagen
    {
        public int Id { get; set; }
        public Image Foto { get; set; }
        public String Titulo { get; set; }
        public String Tipo { get; set; }
        public String Descripcion { get; set; }
    }
}
