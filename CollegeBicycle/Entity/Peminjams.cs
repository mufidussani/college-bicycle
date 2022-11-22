using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle.Entity
{
    public class Peminjams
    {
        // properties
        public string kode_sepeda { get; set; }
        public string nama_peminjam { get; set; }
        public string no_hp { get; set; }

        public Peminjams()
        {

        }

        public Peminjams(string _kode_sepeda, string _nama_peminjam, string _no_hp)
        {
            kode_sepeda = _kode_sepeda;
            nama_peminjam = _nama_peminjam;
            no_hp = _no_hp;
        }
    }
}
