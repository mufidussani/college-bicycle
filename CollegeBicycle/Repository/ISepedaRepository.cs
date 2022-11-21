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
        List<Sepeda> GetSpesificStation(int id);
        void Delete(int id);
        void Update(int id_sepeda, int id_station, string nama_station, string kode_sepeda, string lokasi_sepeda, string ketersediaan_sepeda);
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
                    id_sepeda = (int)rd["id_sepeda"],
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

        public List<Sepeda> GetSpesificStation(int id)
        {
            List<Sepeda> listSepeda = new List<Sepeda>();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from sepeda where id_station = @id_station";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_station", id);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            Console.WriteLine(rd.ToString());
            while (rd.Read())
            {
                Sepeda newSepeda = new Sepeda
                {
                    id_sepeda = (int)rd["id_sepeda"],
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

        public void Delete(int id)
        {
            conn = new NpgsqlConnection(connstring);
            string sql = "delete from sepeda where id_sepeda = @id_sepeda";

            conn.Open();
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_sepeda", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(int id_sepeda, int id_station, string nama_station, string kode_sepeda, string lokasi_sepeda, string ketersediaan_sepeda)
        {
            conn = new NpgsqlConnection(connstring);
            string sql = "update sepeda set id_station = @id_station, nama_station = @nama_station, kode_sepeda = @kode_sepeda, lokasi_sepeda = @lokasi_sepeda, ketersediaan_sepeda = @ketersediaan_sepeda where id_sepeda = @id_sepeda";
            conn.Open();

            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_station", id_station);
            cmd.Parameters.AddWithValue("@nama_station", nama_station);
            cmd.Parameters.AddWithValue("@kode_sepeda", kode_sepeda);
            cmd.Parameters.AddWithValue("@lokasi_sepeda", lokasi_sepeda);
            cmd.Parameters.AddWithValue("@ketersediaan_sepeda", ketersediaan_sepeda);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
