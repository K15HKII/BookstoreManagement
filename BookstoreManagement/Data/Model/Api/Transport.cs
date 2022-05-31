using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class Transport
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("transporter_id")]
        public int TransporterId { get; set; }

        [JsonProperty("tracking")]
        public string Tracking { get; set; }
    }
}
