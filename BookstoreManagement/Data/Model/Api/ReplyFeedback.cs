using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class ReplyFeedback : Message
{
    [JsonProperty("feedback_id")]
    public string FeedbackId { get; set; }
}