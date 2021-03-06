using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api
{
    public class VoucherEditRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userid")]
        public string UserId { get; set; }

        [JsonProperty("profileid")]
        public string ProfileId { get; set; }

        [JsonProperty("vouchercode")]
        public string VoucherCode { get; set; }

        [JsonProperty("expireddate")]
        public DateTime? ExpiredDate { get; set; }

        [JsonProperty("useddate")]
        public DateTime? UsedDate { get; set; }
    }
}
