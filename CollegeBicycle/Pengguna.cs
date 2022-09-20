using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle
{
    class Pengguna
    {
        private int IdPengguna;
        private string NamaPengguna;
        private DateTime TanggalPeminjaman;
        private DateTime TanggalDikembalikan;
        public int KodeSepeda { get; private set; }

        //property
        public string namaPengguna
        {
            get { return NamaPengguna; }
            set { NamaPengguna = value; }
        }
        public int kodeSepeda
        {
            get { return KodeSepeda; }
            set { KodeSepeda = value; }
        }
        public DateTime tanggalPeminjaman
        {
            get { return TanggalPeminjaman; }
            set { TanggalPeminjaman = value; }
        }

        public DateTime tanggaldikembalikan
        {
            get { return TanggalDikembalikan; }
            set { TanggalDikembalikan = value; }
        }

        public Pengguna()
        {

        }
    }
}
