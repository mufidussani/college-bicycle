using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle
{
    class Sepeda
    {
        private int IdSepeda;
        private int KodeSepeda;
        private DateTime TanggalTersedia;
        private string HistorySepeda;
        private double LamaDipinjam;
        private string LokasiSepeda;

        public int kodeSepeda
        {
            get { return KodeSepeda; }
            set { KodeSepeda = value; }
        }
        public DateTime tanggalTersedia
        {
            get { return TanggalTersedia; }
            set { TanggalTersedia = value; }
        }
        public string historySepeda
        {
            get { return HistorySepeda; }
            set { HistorySepeda = value; }
        }

        public double lamaDipinjam
        {
            get { return LamaDipinjam; }
            set { LamaDipinjam = value; }
        }

        public string lokasiSepeda
        {
            get { return LokasiSepeda; }
        }
        public Sepeda()
        {

        }
    }
}
