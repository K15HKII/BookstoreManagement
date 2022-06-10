using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api
{
    public class Bill
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("transport_id")]
        public string? TransportId { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [JsonProperty("userid")]
        public string UserId { get; set; }
        
        [JsonProperty("address_id")]
        public string AddressId { get; set; }

        [JsonProperty("status")]
        public BillStatus? BillStatus { get; set; }

        [JsonProperty("bill_details")]
        public List<BillDetail> ListBillDetail { get; set; }
    }
}
