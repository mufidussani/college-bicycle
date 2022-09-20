using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle
{
    class Station
    {
        protected int _idStation;
        protected string _namaStation;

        public string NamaStation
        {
            get { return _namaStation; }
            set { _namaStation = value; }
        }

        public int IdStation
        {
            get { return _idStation; }
            set { _idStation = value; }
        }

        public Station(int IdStation, string NamaStation)
        {
            _idStation = IdStation;
            _namaStation = NamaStation;
        }
    }
}
