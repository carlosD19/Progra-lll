using System;
using System.Collections.Generic;
using VisorImagenDAL;
using VisorImagenENL;

namespace VisorImagenBOL
{
    public class ImagenBOL
    {
        ImagenDAL dal = new ImagenDAL();
        public bool VerificarImagen(Imagen imagen)
        {
            if(imagen.Foto == null)
            {
                throw new Exception("Imagen requerida.");
            }
            if (String.IsNullOrEmpty(imagen.Tipo))
            {
                throw new Exception("Tipo requerido.");
            }
            if (String.IsNullOrEmpty(imagen.Titulo))
            {
                throw new Exception("Titulo requerido.");
            }
            if (String.IsNullOrEmpty(imagen.Descripcion))
            {
                throw new Exception("Descripción requerida.");
            }
            if (imagen.Id != 0)
            {
                return dal.ModificarImagen(imagen);
            }
            return dal.InsertarImagen(imagen);
        }

        public List<Imagen> CargarTodo(string filtro)
        {
            return dal.CargarTodo(filtro);
        }
        public bool EliminarImagen(int id)
        {
            if(id != 0)
            {
                return dal.EliminarImagen(id);
            }
            return false;
        }
    }
}
