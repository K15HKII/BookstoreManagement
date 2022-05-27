using System;
using BookstoreManagement.Data.Model.Auth;
using Refit;

namespace BookstoreManagement.Data.Remote
{
    public interface IAuthRemote
    {

        [Post("/login")]
        IObservable<LoginResponse> login([Body(BodySerializationMethod.UrlEncoded)] LoginRequest request);

    }
}
