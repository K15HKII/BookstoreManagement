using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Video : Media
{
    [JsonProperty("duration")]
    public int Duration { get; set; }
}