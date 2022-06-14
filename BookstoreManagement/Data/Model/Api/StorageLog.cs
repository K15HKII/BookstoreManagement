using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class StorageLog
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("actor_id")]
    public string ActorId { get; set; }
    
    [JsonProperty("description")]
    public string? Description { get; set; }
    
    [JsonProperty("date")]
    public DateTime Date { get; set; }
    
    [JsonProperty("action")]
    public StorageAction Action { get; set; }
    
    [JsonProperty("details")]
    public List<StorageLogDetail> Details { get; set; }
}