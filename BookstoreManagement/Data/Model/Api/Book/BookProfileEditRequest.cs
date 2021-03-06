using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class BookProfileEditRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tags")]
        public string? Tags { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("authorid")]
        public int AuthorId { get; set; }

        [JsonProperty("publisherid")]
        public int PublisherId { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("ebookfile")]
        public string? PriceDescription { get; set; }
    }
}
