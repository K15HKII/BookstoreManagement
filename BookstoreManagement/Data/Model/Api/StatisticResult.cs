using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class StatisticResult
{
    [JsonProperty("result")]
    public double Result{ get; set; }
}