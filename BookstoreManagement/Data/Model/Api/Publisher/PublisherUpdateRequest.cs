using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class PublisherUpdateRequest
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
}