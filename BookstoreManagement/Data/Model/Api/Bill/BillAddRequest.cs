using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class BillAddRequest
{
    [JsonProperty("date")]
    public DateTime Date { get; set; }

    [JsonProperty("transportid")]
    public string TransportId { get; set; }

    [JsonProperty("userid")]
    public string UserId { get; set; }

    [JsonProperty("billstatus")]
    public BillStatus? BillStatus { get; set; }
}