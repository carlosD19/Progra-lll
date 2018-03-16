using JuegoDadoENL;
using Npgsql;
using System;
using System.Collections.Generic;

namespace JuegoDadoDAL
{
    public class UsuarioDAL
    {
        DadoDAL dal;

        public bool Guardar(UsuarioENL usuario, DadoENL puntaje)
        {
            dal = new DadoDAL();
            try
            {
                int bus = VerificarExistencia(usuario);
                if (bus == 0)
                {
                    using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
                    {
                        con.Open();
                        string sql = @"INSERT INTO usuario(usuario)
	                            VALUES (@usu);";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@usu", usuario.Usuario);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            usuario.Id = VerificarExistencia(usuario);
                            return dal.Guardar(usuario.Id, puntaje);
                        }
                        return false;
                    }
                }
                else
                {
                    if (VerificarUsuario(usuario) != 0)
                    {
                        usuario.Id = VerificarUsuario(usuario);
                        return dal.Guardar(usuario.Id, puntaje);
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<UsuarioENL> CargarTodo()
        {
            List<UsuarioENL> usuarios = new List<UsuarioENL>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select * from usuario";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usuarios.Add(CargarUsuario(reader));
                }
            }

            return usuarios;
        }

        private UsuarioENL CargarUsuario(NpgsqlDataReader reader)
        {
            UsuarioENL usuario = new UsuarioENL();
            usuario.Id = Int32.Parse(reader["id"].ToString());
            usuario.Usuario = reader["usuario"].ToString();
            return usuario;
        }

        internal bool ModificarFecha(int id)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
                {
                    con.Open();
                    string sql = @"UPDATE usuario
	                            SET fecha=@fec
	                            WHERE id=@id";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@fec", DateTime.Now.Date);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private int VerificarExistencia(UsuarioENL usuario)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select *
                            from usuario where usuario = @usu";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usu", usuario.Usuario);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario.Id = Int32.Parse(reader["id"].ToString());
                    return usuario.Id;
                }
                else
                {
                    return 0;
                }
            }
        }

        private int VerificarUsuario(UsuarioENL usuario)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
                {
                    string date = DateTime.Now.Date.ToString();
                    //Abrir una conexion
                    con.Open();
                    //Definir la consulta
                    string sql = "select * from usuario where usuario = @usu";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@usu", usuario.Usuario);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string fecha = reader["fecha"].ToString();
                        if (!fecha.Equals(date))
                        {
                            return Int32.Parse(reader["id"].ToString());
                        }
                        else
                        {
                            throw new Exception("El usuario ya jugó.");
                        }
                    }
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
