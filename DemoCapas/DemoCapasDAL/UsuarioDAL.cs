using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoCapasENL;
using Npgsql;
using System.Drawing;
using System.Drawing.Imaging;

namespace DemoCapasDAL
{
    public class UsuarioDAL
    {
        public List<EUsuario> CargarTodo(string filtro)
        {
            List<EUsuario> usuarios = new List<EUsuario>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select id, cedula, usuario, 
	                            nombre, apellido_uno, apellido_dos, 
		                            pass, email from usuario where
		                            lower(cedula) like @filtro
		                            or lower(nombre) like  @filtro
		                            or lower(usuario) like  @filtro
		                            or lower(apellido_uno) like  @filtro
		                            or lower(email) like  @filtro";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@filtro", filtro.ToLower() + "%");
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(CargarUsuario(reader));
                }

            }

            return usuarios;
        }

        public EUsuario Verificar(EUsuario usuario)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select id, cedula, usuario, 
                               nombre, apellido_uno, apellido_dos, 
                                pass, email from usuario where (usuario = @usuario or email = @email)
                                and pass = @pass";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                cmd.Parameters.AddWithValue("@email", usuario.Email);
                cmd.Parameters.AddWithValue("@pass", usuario.Password);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return CargarUsuario(reader);
                }
            }
            return null;
        }

        public bool Modificar(EUsuario usuario, Image imagen)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"UPDATE usuario
	                            SET cedula=@ced, usuario=@usu, nombre=@nom, 
	                                apellido_uno=@apu, apellido_dos=@aps, 
		                            pass=@pas, email=@ema
	                            WHERE id=@id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ced", usuario.Cedula);
                cmd.Parameters.AddWithValue("@usu", usuario.Usuario);
                cmd.Parameters.AddWithValue("@nom", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apu", usuario.ApellidoUno);
                cmd.Parameters.AddWithValue("@aps", usuario.ApellidoDos);
                cmd.Parameters.AddWithValue("@pas", usuario.Password);
                cmd.Parameters.AddWithValue("@ema", usuario.Email);
                cmd.Parameters.AddWithValue("@id", usuario.Id);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    if (imagen != null)
                    {
                        return ModificarImagen(imagen, usuario.Cedula);
                    }
                    return true;
                }
                return false;
            }
        }

        private bool ModificarImagen(Image imagen, string cedula)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"select id from usuario where cedula = @ced";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ced", cedula);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                MemoryStream stream = new MemoryStream();
                imagen.Save(stream, ImageFormat.Jpeg); //Foto es de tipo Image en C#
                byte[] pic = stream.ToArray();

                string sql1 = @"UPDATE imagen SET imagen = @img WHERE id_usuario = @id;";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@img", pic);
                if(cmd1.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return InsertarImagen(imagen, cedula);
                }
            }
        }

        public void Eliminar(int id)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"DELETE FROM usuario WHERE id = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                EliminarImagen(id);
            }
        }

        public bool Insertar(EUsuario usuario, Image imagen)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"INSERT INTO usuario(cedula, usuario, nombre,
                                apellido_uno, apellido_dos, pass, email)
	                            VALUES (@ced, @usu, @nom, @apu, 
	                            @aps, @pas, @ema);";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ced", usuario.Cedula);
                cmd.Parameters.AddWithValue("@usu", usuario.Usuario);
                cmd.Parameters.AddWithValue("@nom", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apu", usuario.ApellidoUno);
                cmd.Parameters.AddWithValue("@aps", usuario.ApellidoDos);
                cmd.Parameters.AddWithValue("@pas", usuario.Password);
                cmd.Parameters.AddWithValue("@ema", usuario.Email);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    if (imagen != null)
                    {
                        return InsertarImagen(imagen, usuario.Cedula);
                    }
                    return true;
                }
                return false;
            }
        }

        private bool InsertarImagen(Image imagen, string cedula)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"select id from usuario where cedula = @ced";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ced", cedula);
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                MemoryStream stream = new MemoryStream();
                imagen.Save(stream, ImageFormat.Jpeg); //Foto es de tipo Image en C#
                byte[] pic = stream.ToArray();

                string sql1 = @"INSERT INTO imagen(id_usuario, imagen)
	                            VALUES (@id, @img);";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
                cmd1.Parameters.AddWithValue("@id", id);
                cmd1.Parameters.AddWithValue("@img", pic);
                return cmd1.ExecuteNonQuery() > 0;
            }
        }

        private EUsuario CargarUsuario(NpgsqlDataReader reader)
        {
            EUsuario usu = new EUsuario
            {
                //No validar la llave primaria, no es necesario, solo de ejemplo xD
                Id = reader["id"] != DBNull.Value ? Convert.ToInt32(reader["id"]) : 0,
                Cedula = reader["cedula"] != DBNull.Value ? reader["cedula"].ToString() : "Indocumentado",
                Usuario = reader["usuario"].ToString(),
                Nombre = reader["nombre"].ToString(),
                ApellidoUno = reader["apellido_uno"].ToString(),
                ApellidoDos = reader["apellido_dos"].ToString(),
                Password = reader["pass"].ToString(),
                Email = reader["email"].ToString(),
            };
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"select imagen from imagen where id_usuario = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", usu.Id); ;

                byte[] foto = new byte[0];
                NpgsqlDataReader reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    foto = (byte[])reader1["imagen"];
                    MemoryStream stream = new MemoryStream(foto);
                    usu.Imagen = Image.FromStream(stream);
                }
            }
            return usu;
        }
        public bool EliminarImagen(int id)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"DELETE FROM imagen WHERE id_usuario = @id";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
