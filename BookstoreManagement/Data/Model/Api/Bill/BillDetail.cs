using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api
{
    public class BillDetail
    {
        [JsonProperty("bill_id")]
        public int BillId { get; set; }

        [JsonProperty("book_id")]
        public string BookId { get; set; }

        [JsonProperty("unit_price")]
        public float UnitPrice { get; set; }
        
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
