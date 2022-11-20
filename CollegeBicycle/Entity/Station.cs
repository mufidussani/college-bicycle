using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle.Entity
{
    public class Station
    {
        public int id_station { get; set; }
        public string nama_station { get; set; }

        public Station()
        {

        }

        public Station(int _id_station, string _nama_station)
        {
            id_station = _id_station;
            nama_station = _nama_station;
        }
    }
}
