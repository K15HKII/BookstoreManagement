using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class BillDetail
    {
        [JsonProperty("billid")]
        public int BillId { get; set; }

        [JsonProperty("bookid")]
        public string BookId { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }
    }
}
