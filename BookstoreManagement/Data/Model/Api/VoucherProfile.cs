using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class VoucherProfile
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("description")]
        public string? Description { get; set; }
        
        [JsonProperty("discount_type")]
        public DiscountType DiscountType { get; set; }
        
        [JsonProperty("discount")]
        public float Discount { get; set; }
        
        [JsonProperty("require_book_tags")]
        public List<BookTag> RequireBookTags { get; set; }
        
        [JsonProperty("require_book_count")]
        public int RequireBookCount { get; set; }
        
        [JsonProperty("require_min_value")]
        public int RequireMinValue { get; set; }
        
    }
}
