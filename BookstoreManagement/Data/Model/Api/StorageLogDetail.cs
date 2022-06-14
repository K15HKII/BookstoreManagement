using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class StorageLogDetail
{
    [JsonProperty("book_id")]
    public string BookId { get; set; }
    
    [JsonProperty("log_id")]
    public string LogId { get; set; }
    
    [JsonProperty("quantity")]
    public int Quantity { get; set; }
    
}