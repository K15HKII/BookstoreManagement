using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class WildVoucher : BaseVoucher
    {
        [JsonProperty("remaining_uses")]
        public int RemainingUses { get; set; }
        
        [JsonProperty("max_uses")]
        public int MaxUses { get; set; }
        
    }
}
