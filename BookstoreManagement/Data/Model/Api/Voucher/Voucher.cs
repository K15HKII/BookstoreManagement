using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class Voucher : BaseVoucher
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("used_at")]
        public DateTime? UsedAt { get; set; }
    }
}
