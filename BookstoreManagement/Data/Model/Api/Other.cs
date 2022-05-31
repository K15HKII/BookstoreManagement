using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Other : File
{
    [JsonProperty("size")]
    public int Size { get; set; }
}