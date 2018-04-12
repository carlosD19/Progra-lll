using LabPalabraDAL;
using LabPalabraENL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPalabraBOL
{
    public class PalabraBOL
    {
        private PalabraDAL dal;

        public PalabraBOL()
        {
            dal = new PalabraDAL();
        }
        public bool VerificarPalabra(string palabra)
        {
            if (String.IsNullOrEmpty(palabra))
            {
                throw new Exception("Debe ingresar una palabra.");
            }
            return true;
        }
        public PalabraENL CargarPorLetra(string letra)
        {
            if (String.IsNullOrEmpty(letra))
            {
                throw new Exception("Debe ingresar una letra.");
            }
            return dal.CargarPalabra(letra);
        }
        public List<PalabraENL> CargarTodo()
        {
            return dal.CargarTodo();
        }
    }
}
