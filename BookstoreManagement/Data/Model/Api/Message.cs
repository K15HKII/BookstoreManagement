using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Message
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("text")]
    public string? Text { get; set; }
    
}