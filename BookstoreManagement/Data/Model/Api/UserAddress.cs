using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class UserAddress
{
    [JsonProperty("user_id")]
    public string UserId { get; set; }
    
    [JsonProperty("sub_id")]
    public long SubId { get; set; }
    
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [JsonProperty("address")]
    public string Address { get; set; }
    
    [JsonProperty("street")]
    public string Street { get; set; }
    
    [JsonProperty("city")]
    public string City { get; set; }
    
    [JsonProperty("project")]
    public string Project { get; set; }
    
    [JsonProperty("ward")]
    public string Ward { get; set; }
    
    [JsonProperty("district")]
    public string District { get; set; }
    
    [JsonProperty("is_primary")]
    public bool IsPrimary { get; set; }
}