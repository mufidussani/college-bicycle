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
        public string kode_sepeda { get; set; }
        public string nama_station { get; set; }
        public string lokasi_sepeda { get; set; }
        public string ketersediaan_sepeda { get; set; }

        public Sepeda()
        {

        }

        public Sepeda(string _kode_sepeda, string _nama_station, string _lokasi_sepeda, string _ketersediaan_sepeda)
        {
            kode_sepeda = _kode_sepeda;
            nama_station = _nama_station;
            lokasi_sepeda = _lokasi_sepeda;
            ketersediaan_sepeda = _ketersediaan_sepeda;
        }
    }
}
