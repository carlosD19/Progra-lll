using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Npgsql;
using VisorImagenENL;

namespace VisorImagenDAL
{
    public class ImagenDAL
    {
        public List<Imagen> CargarTodo(string filtro)
        {
            List<Imagen> imagenes = new List<Imagen>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select * from imagen where lower(tipo) like @filtro";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@filtro", filtro.ToLower() + "%");
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    imagenes.Add(CargarImagen(reader));
                }

            }

            return imagenes;
        }

        public bool ModificarImagen(Imagen imagen)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                MemoryStream stream = new MemoryStream();
                imagen.Foto.Save(stream, ImageFormat.Jpeg); //Foto es de tipo Image en C#
                byte[] pic = stream.ToArray();
                con.Open();
                string sql = @"UPDATE imagen
	                            SET imagen = @img, titulo = @tit, tipo = @tip, 
	                                descripcion =@desc
	                            WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@img", pic);
                cmd.Parameters.AddWithValue("@tit", imagen.Titulo);
                cmd.Parameters.AddWithValue("@tip", imagen.Tipo);
                cmd.Parameters.AddWithValue("@desc", imagen.Descripcion);
                cmd.Parameters.AddWithValue("@id", imagen.Id);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool InsertarImagen(Imagen imagen)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                MemoryStream stream = new MemoryStream();
                imagen.Foto.Save(stream, ImageFormat.Jpeg); //Foto es de tipo Image en C#
                byte[] pic = stream.ToArray();
                con.Open();
                string sql = @"INSERT INTO imagen(imagen, titulo, tipo, descripcion)
	                            VALUES (@img, @tit, @tip, @desc);";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@img", pic);
                cmd.Parameters.AddWithValue("@tit", imagen.Titulo);
                cmd.Parameters.AddWithValue("@tip", imagen.Tipo);
                cmd.Parameters.AddWithValue("@desc", imagen.Descripcion);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private Imagen CargarImagen(NpgsqlDataReader reader)
        {
            Imagen img = new Imagen
            {
                //No validar la llave primaria, no es necesario, solo de ejemplo xD
                Id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0,
                Descripcion = reader["descripcion"].ToString(),
                Tipo = reader["tipo"].ToString(),
                Titulo = reader["titulo"].ToString()
            };
            byte[] foto = new byte[0];

            foto = (byte[])reader["imagen"];
            MemoryStream stream = new MemoryStream(foto);
            img.Foto = Image.FromStream(stream);

            return img;
        }

        public bool EliminarImagen(int id)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"DELETE FROM imagen WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
