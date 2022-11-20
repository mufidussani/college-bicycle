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
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
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
                    kode_sepeda = rd["kode_sepeda"].ToString(),
                    nama_station = rd["nama_station"].ToString(),
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
