using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class CartItem
    {
        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("bookprofile")]
        public string BookProfile { get; set; }

        [JsonProperty("selected")]
        public bool Selected { get; set; }
    }
}
