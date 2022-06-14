using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api
{
    public class Lend
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("book_id")]
        public string BookId { get; set; }
        
        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("tags")]
        public LendStatus Status { get; set; }

        [JsonProperty("start_date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("end_date")]
        public DateTime EndDate { get; set; }
        
        [JsonProperty("payment")]
        public Payment Payment { get; set; }
        
    }
}
