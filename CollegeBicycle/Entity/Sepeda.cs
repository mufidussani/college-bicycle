using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle.Entity
{
    public class Sepeda
    {
        // properties
        public int id_sepeda { get; set; }
        public int id_station { get; set; }
        public string kode_sepeda { get; set; }
        public string lokasi_sepeda { get; set; }
        public string ketersediaan_sepeda { get; set; }

        public Sepeda()
        {

        }

        public Sepeda(int _id_sepeda, int _id_station, string _kode_sepeda, string _lokasi_sepeda, string _ketersediaan_sepeda)
        {
            id_sepeda = _id_sepeda;
            id_station = _id_station;
            kode_sepeda = _kode_sepeda;
            lokasi_sepeda = _lokasi_sepeda;
            ketersediaan_sepeda = _ketersediaan_sepeda;
        }
    }
}
