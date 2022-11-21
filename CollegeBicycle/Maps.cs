using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeBicycle
{
    internal class Maps
    {
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class root
        {
            public coord coord { get; set; }
        }
    }
}
