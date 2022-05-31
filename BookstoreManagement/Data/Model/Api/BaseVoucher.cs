using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public abstract class BaseVoucher
{
    [JsonProperty("id")]
    public string Id { get; set; }
    
    [JsonProperty("code")]
    public string Code { get; set; }
    
    [JsonProperty("release_date")]
    public DateTime ReleaseDate { get; set; }
    
    [JsonProperty("expired_date")]
    public DateTime ExpiredDate { get; set; }
    
    [JsonProperty("profile_id")]
    public string ProfileId { get; set; }
}