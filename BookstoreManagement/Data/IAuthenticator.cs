using System;

namespace BookstoreManagement.Data;

public interface IAuthenticator
{
    IObservable<bool> Authenticate(string username, string password);
}