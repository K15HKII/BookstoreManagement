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
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("book_id")]
        public string BookId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        
        [JsonProperty("selected")]
        public bool Selected { get; set; }
    }
}
