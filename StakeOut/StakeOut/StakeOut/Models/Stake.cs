using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeOut.Models
{
    class Stake
    {
        public string tournament { get; set; }
        public string venue { get; set; }
        public DateTime date;
        public double markup { get; set; }
        public double stake { get; set; }
        public string comments { get; set; }
        public Profile profile { get; set; }
    }
}
