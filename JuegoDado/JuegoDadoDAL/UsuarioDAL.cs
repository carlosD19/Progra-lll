using JuegoDadoENL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDadoDAL
{
    public class UsuarioDAL
    {
        private DadoDAL dal = new DadoDAL();
        public bool Guardar(UsuarioENL usuario, DadoENL puntaje)
        {
            if (!VerificarExistencia(usuario))
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
                {
                    con.Open();
                    string sql = @"INSERT INTO usuario(usuario)
	                            VALUES (@usu);";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@usu", usuario.Usuario);

                    if(cmd.ExecuteNonQuery() > 0)
                    {
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

        private bool VerificarExistencia(UsuarioENL usuario)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select usuario
                            from usuario where (usuario = @usuario)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                return reader.Read();
            }
        }

        private int VerificarUsuario(UsuarioENL usuario)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                string date = DateTime.Now.Date.ToString("yyyy/MM/dd");
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
                        return Int32.Parse(reader["usuario"].ToString());
                    }
                }
                return 0;
            }
        }
    }
}
