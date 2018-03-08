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

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            else
            {
                if (VerificarUsuario(usuario))
                {
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

        private bool VerificarUsuario(UsuarioENL usuario)
        {
            string s = usuario.Fecha.ToString();
            string s2 = DateTime.Parse(s).ToShortDateString();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select usuario
                            from usuario where (usuario = @usuario, and fecha != @fec)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usuario", usuario.Usuario);
                cmd.Parameters.AddWithValue("@fec", s2);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                DateTime date = DateTime.Now;
                return reader.Read();
            }
        }
    }
}
