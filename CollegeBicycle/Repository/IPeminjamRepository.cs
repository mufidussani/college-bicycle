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
        void Add(string nama_station, string kode_sepeda, string nama_peminjam, string nim_peminjam, string no_hp, string tanggal_pinjam, string tanggal_kembali);
    }
    public class PeminjamRepository : IPeminjamRepository
    {
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
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

        public void Add(string nama_station, string kode_sepeda, string nama_peminjam, string nim_peminjam, string no_hp, string tanggal_pinjam, string tanggal_kembali)
        {
            conn = new NpgsqlConnection(connstring);
            string sql = "insert into peminjam(nama_station, kode_sepeda, nama_peminjam, nim_peminjam, no_handphone, tanggal_pinjam, tanggal_kembali) values('" + nama_station + "','" + kode_sepeda + "','" + nama_peminjam + "','" + nim_peminjam + "','" + no_hp + "','" + tanggal_pinjam + "','" + tanggal_kembali + "')";

            conn.Open();
            cmd = new NpgsqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
