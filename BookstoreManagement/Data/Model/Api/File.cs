using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public abstract class File
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("path")]
    public string Path { get; set; }
    
}