using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeOut.Models
{
    class Profile
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string HendonMobLink { get; set; }
        public string TwitterLink { get; set; }
        public int Pin { get; set; }
        public string ProfilePicture { get; set; }
        public List<Stake> Stakelist;
    }
}
