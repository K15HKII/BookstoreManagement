using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Message
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("user_id")]
    public string UserId { get; set; }
    
    [JsonProperty("text")]
    public string? Text { get; set; }
    
    [JsonProperty("images")]
    public List<Image>? Images { get; set; }
    
    [JsonProperty("videos")]
    public List<Video>? Videos { get; set; }
    
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    
}