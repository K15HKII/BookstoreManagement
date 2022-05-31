using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Data.Model.Api.Customer
{
    public class UserEditRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("firstname")]
        public string? FirstName { get; set; }

        [JsonProperty("lastname")]
        public string? LastName { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("role")]
        public Role? Role { get; set; }

        [JsonProperty("refresh_token")]
        public string? Refresh_token { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("is_active")]
        public bool Is_Active { get; set; }

        [JsonProperty("is_verified")]
        public bool Is_Verified { get; set; }

        [JsonProperty("is_locked")]
        public bool Is_Locked { get; set; }

        [JsonProperty("is_blocked")]
        public bool Is_Blocked { get; set; }

        public String FullName { get { return FirstName + " " + LastName; } }
    }
}
