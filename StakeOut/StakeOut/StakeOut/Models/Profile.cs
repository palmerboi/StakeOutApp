using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeOut.Models
{
    class Profile
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime dob;
        public string description { get; set; }
        public string hendonMobLink { get; set; }
        public string twitterLink { get; set; }
        public string pin { get; set; }
        public string profilePicture { get; set; }
        public List<Stake> stakelist;

        public void stakeGetter()
        {

        }
    }
}
