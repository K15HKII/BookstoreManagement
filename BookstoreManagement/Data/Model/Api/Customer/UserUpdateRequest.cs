using System;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Api
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

        [JsonProperty("create_at")]
        public DateTime? Create_at { get; set; }

        public String FullName => FirstName + " " + LastName;
    }
}
