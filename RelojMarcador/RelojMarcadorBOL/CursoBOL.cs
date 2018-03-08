using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;

namespace RelojMarcadorBOL
{
    public class CursoBOL
    {
        public CursoDAL dal = new CursoDAL();

        public bool AgregarCurso(Curso curso, bool funcion)
        {
            if (String.IsNullOrEmpty(curso.Nombre))
            {
                throw new Exception("Nombre requerido.");
            }
            if (String.IsNullOrEmpty(curso.CodHorario))
            {
                throw new Exception("Codigo requerido.");
            }
            if (String.IsNullOrEmpty(curso.FechaIni.ToString())
                || String.IsNullOrEmpty(curso.FechaFin.ToString()))
            {
                throw new Exception("Fecha de inicio y fin requeridas.");
            }
            if (curso.Aula < 0)
            {
                throw new Exception("Numero de aula requerido.");
            }
            if (!funcion)
            {
                return dal.ModificarCurso(curso);
            }
            return dal.GuardarCurso(curso);
        }
        public bool EliminarCurso(string cedula)
        {
            return dal.EliminarCurso(cedula);
        }
    }
}
