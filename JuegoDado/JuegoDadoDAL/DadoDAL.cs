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
        public bool Guardar(int id, DadoENL puntaje)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"INSERT INTO puntaje(id_usuario, punto)
	                            VALUES (@usu, @punt);";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@usu", id);
                cmd.Parameters.AddWithValue("@punt", puntaje.Puntaje);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
