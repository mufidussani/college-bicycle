using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle
{
    class PeminjamanSepeda
    {
        private string InformasiPeminjam;
        private string KetersediaanSepeda;
        private double NotaPeminjaman;

        public string informasiSepeda
        {
            get { return InformasiPeminjam; }
        }
        public string ketersediaanSepeda
        {
            get { return KetersediaanSepeda; }
        }
        public double notaPeminjaman
        {
            get { return NotaPeminjaman; }
        }
        
        public PeminjamanSepeda()
        {

        }
    }
}
