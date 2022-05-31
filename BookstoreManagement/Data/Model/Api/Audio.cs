using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Audio : Media
{
    [JsonProperty("duration")]
    public int Duration { get; set; }
}