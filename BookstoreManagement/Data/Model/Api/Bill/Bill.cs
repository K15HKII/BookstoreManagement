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

        [JsonProperty("transport_id")]
        public string? TransportId { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("status")]
        public BillStatus? BillStatus { get; set; }

        [JsonProperty("bill_details")]
        public List<BillDetail> ListBillDetail { get; set; }
    }
}
