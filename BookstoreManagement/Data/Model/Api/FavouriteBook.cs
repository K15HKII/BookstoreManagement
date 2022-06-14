using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class FavouriteBook
{
    [JsonProperty("user_id")]
    public string UserId { get; set; }
    
    [JsonProperty("book")]
    public Book Book { get; set; }
    
    [JsonProperty("book_id")]
    public string BookId { get; set; }
}