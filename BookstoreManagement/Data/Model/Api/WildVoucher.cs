using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class WildVoucher
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profileid")]
        public string ProfileId { get; set; }

        [JsonProperty("amount")]
        public int? Amount { get; set; }

        [JsonProperty("releasedate")]
        public DateTime? ReleaseDate { get; set; }

        //TODO fix model

        //[JsonProperty("expirydate")]
        //public DateTime? ExpiryDate { get; set; }

        //[JsonProperty("used")]
        
    }
}
