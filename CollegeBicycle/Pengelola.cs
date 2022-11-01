using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle
{
    internal class Pengelola
    {
        public Pengelola() { }
        public Pengelola(string pengelolaName, string password)
        {
            PengelolaName = pengelolaName;
            PengelolaPassword = password;
        }

        private int _pengelolaID;
        private string _pengelolaName;
        private string _pengelolaPassword;

        public int PengelolaID
        {
            get { return _pengelolaID; }
        }

        public string PengelolaName
        {
            get {  return _pengelolaName; }
            set { _pengelolaName = value; }
        }

        public string PengelolaPassword
        {
            get { return _pengelolaPassword; }
            set { _pengelolaPassword = value; }
        }
    
        public bool Login()
        {
            if(PengelolaName == "Sani" & PengelolaPassword == "asd")
            {
                _pengelolaID = 1;
                return true;
            }
            else if (PengelolaName == "Nia" & PengelolaPassword == "asd")
            {
                _pengelolaID = 2;
                return true;
            }
            else if (PengelolaName == "Dinda" & PengelolaPassword == "asd")
            {
                _pengelolaID = 3;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
