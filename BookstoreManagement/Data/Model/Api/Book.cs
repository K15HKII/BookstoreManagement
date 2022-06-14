using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class Book
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }
        
        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("stock")]
        public int Stock { get; set; }
        
        [JsonProperty("author_id")]
        public int AuthorId { get; set; }
        
        [JsonProperty("price")]
        public float Price { get; set; }
        
        [JsonProperty("publisher_id")]
        public int? PublisherId { get; set; }

        [JsonProperty("tag")]
        public BookTag? Tag { get; set; }
        
        [JsonProperty("images")]
        public List<Image>? Images { get; set; }
        
        [JsonProperty("videos")]
        public List<Video>? Videos { get; set; }    

    }
}
