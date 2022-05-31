using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BookstoreManagement.Services
{
    public class HttpAuthHandler : DelegatingHandler
    {
        
        private readonly LoginSession _loginSession;
        
        public HttpAuthHandler(LoginSession loginSession)
        {
            _loginSession = loginSession;
        }
        
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("access_token", _loginSession.AccessToken);
            request.Headers.Add("refresh_token", _loginSession.RefreshToken);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

    }
}
