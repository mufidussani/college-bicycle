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
    public interface IStationRepository
    {
        List<Station> GetAll();
    }
    public class StationRepository : IStationRepository
    {
        private NpgsqlConnection conn;
        string connstring = "Host=database-1.c3sblevz37wv.ap-northeast-1.rds.amazonaws.com;Port=5432;Username=postgres;Password=collegebicycle;Database=collegebicycle";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        public List<Station> GetAll()
        {
            List<Station> listStation = new List<Station>();
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            sql = "select * from station";
            cmd = new NpgsqlCommand(sql, conn);
            dt = new DataTable();
            NpgsqlDataReader rd = cmd.ExecuteReader();
            Console.WriteLine(rd.ToString());
            while (rd.Read())
            {
                Station newStation = new Station
                {
                    id_station = (int)rd["id_station"],
                    nama_station = rd["nama_station"].ToString(),
                };
                listStation.Add(newStation);
            }
            rd.Close();
            conn.Close();
            return listStation;
        }
    }
}
