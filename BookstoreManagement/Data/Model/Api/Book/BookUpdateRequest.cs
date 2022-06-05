using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api
{
    public class BookUpdateRequest
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
        
        [JsonProperty("isbn")]
        public string? Isbn { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
        
        [JsonProperty("author_id")]
        public string? AuthorId { get; set; }
        
        [JsonProperty("publisher_id")]
        public string? PublisherId { get; set; }

    }
}
