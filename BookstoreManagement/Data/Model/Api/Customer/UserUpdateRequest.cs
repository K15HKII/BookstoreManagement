using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api.Customer
{
    public class UserUpdateRequest
    {
        [JsonProperty("firstname")]
        public string? FirstName { get; set; }

        [JsonProperty("lastname")]
        public string? LastName { get; set; }
        
        [JsonProperty("email")]
        public string? Email { get; set; }
        
        [JsonProperty("username")]
        public string Username { get; set; }
        
        [JsonProperty("age")]
        public int? Age { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }
        
        [JsonProperty("gender")]
        public Gender Gender { get; set; } 
        
        [JsonProperty("birthday")]
        public DateTime? Birthday { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
        
        [JsonProperty("salt")]
        public string Salt { get; set; }

        [JsonProperty("role")]
        public Role? Role { get; set; }

        [JsonProperty("refresh_token")]
        public string? Refresh_token { get; set; }

        public String FullName => FirstName + " " + LastName;
    }
}
