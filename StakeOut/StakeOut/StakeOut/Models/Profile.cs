using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StakeOut.Models
{
    class Profile
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }

        [JsonProperty(PropertyName = "dob")]
        public DateTime dob;

        [JsonProperty(PropertyName = "description")]
        public string description { get; set; }

        [JsonProperty(PropertyName = "hendonMobLink")]
        public string hendonMobLink { get; set; }

        [JsonProperty(PropertyName = "twitterlink")]
        public string twitterLink { get; set; }

        [JsonProperty(PropertyName = "pin")]
        public string pin { get; set; }

        [JsonProperty(PropertyName = "profilePicture")]
        public string profilePicture { get; set; }

        [JsonProperty(PropertyName = "stakeList")]
        public List<Stake> stakelist;
    }
}
