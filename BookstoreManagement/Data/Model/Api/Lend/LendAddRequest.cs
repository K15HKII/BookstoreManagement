using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class LendAddRequest
{
    [JsonProperty("userid")]
    public string UserId { get; set; }

    [JsonProperty("bookprofileid")]
    public string BookProfileId { get; set; }

    [JsonProperty("start")]
    public DateTime Start { get; set; }

    [JsonProperty("end")]
    public DateTime End { get; set; }
}