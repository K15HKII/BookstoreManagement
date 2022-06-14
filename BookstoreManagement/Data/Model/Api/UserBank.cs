using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class UserBank
{
    [JsonProperty("user_id")]
    public string UserId { get; set; }
    
    [JsonProperty("sub_id")]
    public long SubId { get; set; }
    
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [JsonProperty("bank_name")]
    public string BankName { get; set; }
    
    [JsonProperty("iban")]
    public string Iban { get; set; }
    
    [JsonProperty("bic")]
    public string Bic { get; set; }
    
    [JsonProperty("is_primary")]
    public bool IsPrimary { get; set; }
}