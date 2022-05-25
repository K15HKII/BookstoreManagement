using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BookstoreManagement.Data.Model.Auth
{
    public class LoginResponse
    {

        [JsonProperty("access_token")]
        public string? AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string? RefreshToken { get; set; }

        [JsonProperty(Required = Required.Always, PropertyName = "authenticated")]
        public bool IsAuthenticated { get; set; } 

    }
}
