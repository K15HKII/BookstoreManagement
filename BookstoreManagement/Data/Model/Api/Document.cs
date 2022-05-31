using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Document : File
{
    [JsonProperty("size")]
    public int Size { get; set; }
}