using JuegoDadoENL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDadoDAL
{
    public class DadoDAL
    {
        UsuarioDAL dal = new UsuarioDAL();
        
        public bool Guardar(int id, DadoENL puntaje)
        {
            try
            {
                using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
                {
                    con.Open();
                    string sql = @"INSERT INTO puntaje(id_usuario, punto)
	                            VALUES (@usu, @punt);";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@usu", id);
                    cmd.Parameters.AddWithValue("@punt", puntaje.Puntaje);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return dal.ModificarFecha(id);
                    }
                    else
                    {
                        return false;
                    }
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DadoENL> CargarTodo()
        {
            List<DadoENL> dados = new List<DadoENL>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                //Abrir una conexion
                con.Open();
                //Definir la consulta
                string sql = @"select * from puntaje
                                order by punto desc
                                limit 5";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dados.Add(CargarDado(reader));
                }
            }

            return  dados;

        }

        private DadoENL CargarDado(NpgsqlDataReader reader)
        {
            DadoENL dado = new DadoENL();
            dado.Id_Usuario = Int32.Parse(reader["id_usuario"].ToString());
            dado.Puntaje = Int32.Parse(reader["punto"].ToString());
            return dado;
        }
    }
}
