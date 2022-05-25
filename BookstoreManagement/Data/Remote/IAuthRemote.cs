using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookstoreManagement.Data.Model.Auth;
using Refit;

namespace BookstoreManagement.Data.Remote
{
    public interface IAuthRemote
    {

        [Post("/login")]
        Task<LoginResponse> login([Body(BodySerializationMethod.UrlEncoded)] LoginRequest request);

    }
}
