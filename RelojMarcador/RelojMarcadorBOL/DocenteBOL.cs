using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;

namespace RelojMarcadorBOL
{
    public class DocenteBOL
    {
        public DocenteDAL dal = new DocenteDAL();

        public bool AgregarDocente(Docente docente, int rePin, bool funcion)
        {
            if (String.IsNullOrEmpty(docente.Nombre)
                || String.IsNullOrEmpty(docente.ApellidoUno)
                || String.IsNullOrEmpty(docente.ApellidoDos)
                || String.IsNullOrEmpty(docente.Cedula)
                || String.IsNullOrEmpty(docente.Email)
                || String.IsNullOrEmpty(docente.Telefono.ToString()))
            {
                throw new Exception("Datos personales requeridos.");
            }
            if (String.IsNullOrEmpty(docente.Pin.ToString()))
            {
                throw new Exception("PIN requerido.");
            }
            if (docente.Pin != rePin)
            {
                throw new Exception("PIN no coincide.");
            }
            if (!funcion)
            {
                return dal.ModificarDocente(docente);
            }
            return dal.GuardarDocente(docente);
        }
        public bool EliminarDocente(string cedula)
        {
            return dal.EliminarDocente(cedula);
        }
    }
}
