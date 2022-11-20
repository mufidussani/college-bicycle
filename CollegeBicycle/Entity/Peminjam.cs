using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle.Entity
{
    public class Peminjam
    {
        // properties
        public string nama_station { get; set; }
        public string kode_sepeda { get; set; }
        public string nama_peminjam { get; set; }
        public string nim_peminjam { get; set; }
        public string no_hp { get; set; }
        public string tanggal_pinjam { get; set; }
        public string tanggal_kembali { get; set; }

        public Peminjam()
        {

        }

        public Peminjam(string _nama_station, string _kode_sepeda, string _nama_peminjam, string _nim_peminjam, string _no_hp, string _tanggal_pinjam, string _tanggal_kembali)
        {
            nama_station = _nama_station;
            kode_sepeda = _kode_sepeda;
            nama_peminjam = _nama_peminjam;
            nim_peminjam = _nim_peminjam;
            no_hp = _no_hp;
            tanggal_pinjam = _tanggal_pinjam;
            tanggal_kembali = _tanggal_kembali;
        }
    }
}
