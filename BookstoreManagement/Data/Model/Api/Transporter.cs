using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api
{
    public class Transporter
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
        
        [JsonProperty("avatar_id")]
        public string? AvatarId { get; set; }
        
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}
