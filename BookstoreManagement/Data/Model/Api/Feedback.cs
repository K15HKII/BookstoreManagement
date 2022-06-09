using System.Collections.Generic;
using System.Windows.Documents;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class Feedback : Message
{
    [JsonProperty("replies")]
    public List<ReplyFeedback> Replies { get; set; }
    
    [JsonProperty("rating")]
    public double Rating { get; set; }
}