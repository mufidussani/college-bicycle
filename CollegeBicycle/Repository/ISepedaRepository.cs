using CollegeBicycle.Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle.Repository
{
    public interface ISepedaRepository
    {
        List<Sepeda> GetAll();
    }

    // class
    public class SepedaRepository : ISepedaRepository
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=mufidussani;Password=mufidussani;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        public List<Sepeda> GetAll()
        {
            List<Sepeda> listSepeda = new List<Sepeda>();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from sepeda";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            Console.WriteLine(rd.ToString());
            while (rd.Read())
            {
                Sepeda newSepeda = new Sepeda
                {
                    id_sepeda = (int)rd["id_sepeda"],
                    id_station = (int)rd["id_station"],
                    kode_sepeda = rd["kode_sepeda"].ToString(),
                    lokasi_sepeda = rd["lokasi_sepeda"].ToString(),
                    ketersediaan_sepeda = rd["ketersediaan_sepeda"].ToString()
                };
                listSepeda.Add(newSepeda);
            }
            rd.Close();
            conn.Close();
            return listSepeda;
        }

    }
}
