using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class PublisherEditRequest
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
}