using System.Collections.Generic;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api;

public class BookTagVoucher : VoucherProfile
{
    [JsonProperty("tags")]
    public List<BookTag> Tags { get; set; }
}