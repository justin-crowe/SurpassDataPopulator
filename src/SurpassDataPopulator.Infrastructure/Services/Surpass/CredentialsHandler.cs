using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SurpassDataPopulator.Application.Interfaces.Services;

namespace SurpassDataPopulator.Infrastructure.Services.Surpass;

public class CredentialsHandler : DelegatingHandler
{
    private readonly ICredentialsStore _credentialsStore;

    public CredentialsHandler(ICredentialsStore credentialsStore)
    {
        _credentialsStore = credentialsStore;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var credentials = _credentialsStore.Load();
        if (credentials != null)
        {
            var username = credentials.Username;
            var password = credentials.Password;
            var authValue = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", authValue);
            
        }
        return base.SendAsync(request, cancellationToken);
    }
}