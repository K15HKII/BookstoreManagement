using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class Bill
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("transportid")]
        public string TransportId { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("billstatus")]
        public BillStatus? BillStatus { get; set; }

    }
}
