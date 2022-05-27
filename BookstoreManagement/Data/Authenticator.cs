using System;
using System.Reactive.Linq;
using BookstoreManagement.Data.Model.Auth;
using BookstoreManagement.Data.Remote;
using BookstoreManagement.Services;
using Microsoft.Extensions.Logging;

namespace BookstoreManagement.Data;

public class Authenticator : IAuthenticator
{

    private readonly ILogger _logger;
    private readonly IAuthRemote _remote;
    private readonly LoginSession _session;

    public Authenticator(ILogger<Authenticator> logger, IAuthRemote remote, LoginSession session)
    {
        _logger = logger;
        _remote = remote;
        _session = session;
    }

    public IObservable<bool> Authenticate(string username, string password)
    {
        return _remote.login(new LoginRequest()
        {
            Username = username,
            Password = password
        }).Select(response =>
        {
            if (!response.IsAuthenticated) return response.IsAuthenticated;

            _session.AccessToken = response.AccessToken;
            _session.RefreshToken = response.RefreshToken;

            return response.IsAuthenticated;
        });
    }
}