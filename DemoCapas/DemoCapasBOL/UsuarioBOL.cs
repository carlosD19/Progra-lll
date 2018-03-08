using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoCapasDAL;
using DemoCapasENL;
using System.Drawing;

namespace DemoCapasBOL
{
    public class UsuarioBOL
    {
        private UsuarioDAL dal;

        public UsuarioBOL()
        {
            dal = new UsuarioDAL();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<EUsuario> CargarUsuarios(string filtro)
        {
            //Validaciones, procesar información 

            return dal.CargarTodo(filtro);
        }

        public EUsuario Login(EUsuario usuario)
        {
            if (String.IsNullOrEmpty(usuario.Usuario) || String.IsNullOrEmpty(usuario.Email))
            {
                return null;
            }

            if (String.IsNullOrEmpty(usuario.Password))
            {
                return null;
            }

            if (!SeguridadPass(usuario.Password))
            {
                return null;
            }


            return dal.Verificar(usuario);
        }

        public bool Guardar(EUsuario usuario, string rePass, Image imagen)
        {
            
            if (String.IsNullOrEmpty(usuario.Nombre)
                || String.IsNullOrEmpty(usuario.ApellidoUno)
                || String.IsNullOrEmpty(usuario.ApellidoDos)
                || String.IsNullOrEmpty(usuario.Cedula))
            {
                throw new Exception("Datos personales requeridos");
            }

            if (String.IsNullOrEmpty(usuario.Email)
                || String.IsNullOrEmpty(usuario.Usuario)
                || String.IsNullOrEmpty(usuario.Password))
            {
                throw new Exception("Datos de usuario requeridos");
            }

            if (!SeguridadPass(usuario.Password))
            {
                throw new Exception("Contraseña no cumple mínimo de seguridad");
            }

            if (!usuario.Password.Equals(rePass))
            {
                throw new Exception("Contraseñas no coinciden");
            }

            if (usuario.Id > 0)
            {
                return dal.Modificar(usuario,imagen);
            }
            else
            {
                return dal.Insertar(usuario, imagen);
            }
        }

        private bool SeguridadPass(string password)
        {
            return password.Length >= 8;

        }

        public void Eliminar(int id)
        {
            if (id > 0)
            {
                dal.Eliminar(id);
            }
        }
        public bool EliminarImagen(int id)
        {
            if (id > 0)
            {
                return dal.EliminarImagen(id);
            }
            return false;
        }
    }
}
