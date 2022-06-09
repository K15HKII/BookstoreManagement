using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Image : Media
{
    [JsonProperty("width")]
    public int Width { get; set; }
    
    [JsonProperty("height")]
    public int Height { get; set; }
    
}