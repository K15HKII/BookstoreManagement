using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public abstract class Image : Media
{
    [JsonProperty("width")]
    public int Width { get; set; }
    
    [JsonProperty("height")]
    public int Height { get; set; }
    
    
}