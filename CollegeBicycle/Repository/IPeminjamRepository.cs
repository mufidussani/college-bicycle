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
    public interface IPeminjamRepository
    {
        List<Peminjam> GetAll();
        List<Peminjam> GetSpesificStation(string name);
        void Add(string nama_station, string kode_sepeda, string nama_peminjam, string nim_peminjam, string no_hp, DateTime tanggal_pinjam, DateTime tanggal_kembali);
        void Update(int id_peminjam, string nama_station, string kode_sepeda, string nama_peminjam, string nim_peminjam, string no_hp, DateTime tanggal_pinjam, DateTime tanggal_kembali);
        void Delete(int id_peminjam);
    }
    public class PeminjamRepository : IPeminjamRepository
    {
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public DataTable dt;

        public List<Peminjam> GetAll()
        {
            List<Peminjam> listPeminjam = new List<Peminjam>();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from peminjam";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            Console.WriteLine(rd.ToString());
            while (rd.Read())
            {
                Peminjam newPeminjam = new Peminjam
                {
                    id_peminjam = (int)rd["id_peminjam"],
                    nama_peminjam = rd["nama_peminjam"].ToString(),
                    nim_peminjam = rd["nim_peminjam"].ToString(),
                    no_hp = rd["no_handphone"].ToString(),
                    kode_sepeda = rd["kode_sepeda"].ToString(),
                    nama_station = rd["nama_station"].ToString(),
                    tanggal_pinjam = rd["tanggal_pinjam"].ToString(),
                    tanggal_kembali = rd["tanggal_kembali"].ToString()
                };
                listPeminjam.Add(newPeminjam);
            }
            rd.Close();
            conn.Close();
            return listPeminjam;
        }

        public void Add(string nama_station, string kode_sepeda, string nama_peminjam, string nim_peminjam, string no_hp, DateTime tanggal_pinjam, DateTime tanggal_kembali)
        {
            conn = new NpgsqlConnection(connstring);
            string sql = "insert into peminjam(nama_station, kode_sepeda, nama_peminjam, nim_peminjam, no_handphone, tanggal_pinjam, tanggal_kembali) values('" + nama_station + "','" + kode_sepeda + "','" + nama_peminjam + "','" + nim_peminjam + "','" + no_hp + "','" + tanggal_pinjam + "','" + tanggal_kembali + "')";
            conn.Open();
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(int id_peminjam, string nama_station, string kode_sepeda, string nama_peminjam, string nim_peminjam, string no_hp, DateTime tanggal_pinjam, DateTime tanggal_kembali)
        {
            conn = new NpgsqlConnection(connstring);
            string sql = "update peminjam set nama_station = @nama_station, kode_sepeda = @kode_sepeda, nama_peminjam = @nama_peminjam, nim_peminjam = @nim_peminjam, no_handphone = @no_hp, tanggal_pinjam = @tanggal_pinjam, tanggal_kembali = @tanggal_kembali where id_peminjam = @id_peminjam";
            conn.Open();

            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_peminjam", id_peminjam);
            cmd.Parameters.AddWithValue("@nama_station", nama_station);
            cmd.Parameters.AddWithValue("@kode_sepeda", kode_sepeda);
            cmd.Parameters.AddWithValue("@nama_peminjam", nama_peminjam);
            cmd.Parameters.AddWithValue("@nim_peminjam", nim_peminjam);
            cmd.Parameters.AddWithValue("@no_hp", no_hp);
            cmd.Parameters.AddWithValue("@tanggal_pinjam", tanggal_pinjam);
            cmd.Parameters.AddWithValue("@tanggal_kembali", tanggal_kembali);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int id)
        {
            conn = new NpgsqlConnection(connstring);
            string sql = "delete from peminjam where id_peminjam = @id_peminjam";

            conn.Open();
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_peminjam", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Peminjam> GetSpesificStation(string name)
        {
            List<Peminjam> listPeminjam = new List<Peminjam>();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from peminjam where nama_station = @nama_station";
            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama_station", name);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            Console.WriteLine(rd.ToString());
            while (rd.Read())
            {
                Peminjam newPeminjam = new Peminjam
                {
                    id_peminjam = (int)rd["id_peminjam"],
                    nama_peminjam = rd["nama_peminjam"].ToString(),
                    nim_peminjam = rd["nim_peminjam"].ToString(),
                    no_hp = rd["no_handphone"].ToString(),
                    kode_sepeda = rd["kode_sepeda"].ToString(),
                    nama_station = rd["nama_station"].ToString(),
                    tanggal_pinjam = rd["tanggal_pinjam"].ToString(),
                    tanggal_kembali = rd["tanggal_kembali"].ToString()
                };
                listPeminjam.Add(newPeminjam);
            }
            rd.Close();
            conn.Close();
            return listPeminjam;
        }
    }
}
