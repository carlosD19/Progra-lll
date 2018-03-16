using JuegoDadoDAL;
using JuegoDadoENL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDadoBOL
{
    public class UsuarioBOL
    {
        private UsuarioDAL dal;

        public bool VerificarUsu(UsuarioENL usuario, DadoENL puntaje)
        {
            dal = new UsuarioDAL();
            if (String.IsNullOrEmpty(usuario.Usuario))
            {
                throw new Exception("Usuario requerido.");
            }
            if (String.IsNullOrEmpty(usuario.Fecha.ToString()))
            {
                throw new Exception("Fecha requerida.");
            }
            return dal.Guardar(usuario, puntaje);
        }

        public List<UsuarioENL> CargarTodo()
        {
            dal = new UsuarioDAL();
            return dal.CargarTodo();
        }
    }
}
