using LabPalabraENL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPalabraDAL
{
    public class PalabraDAL
    {
        public PalabraENL CargarPalabra(string letra)
        {
            PalabraENL palabra = new PalabraENL();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"SELECT * FROM palabra
                                WHERE palabra.palabra LIKE @letra
                                ORDER BY RANDOM()
                                LIMIT 1 ";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@letra", letra.ToUpper() + "%");
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    palabra = CargarP(reader);
                }
            }
            return palabra;
        }

        public List<PalabraENL> CargarTodo()
        {
            List<PalabraENL> palabra = new List<PalabraENL>();
            using (NpgsqlConnection con = new NpgsqlConnection(Configuracion.ConStr))
            {
                con.Open();
                string sql = @"SELECT * FROM palabra";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    palabra.Add(CargarP(reader));
                }
            }
            return palabra;
        }

        private PalabraENL CargarP(NpgsqlDataReader reader)
        {
            PalabraENL p = new PalabraENL();
            p.Id = Int32.Parse(reader["id"].ToString());
            p.Palabra = reader["palabra"].ToString();
            return p;
        }
    }
}
