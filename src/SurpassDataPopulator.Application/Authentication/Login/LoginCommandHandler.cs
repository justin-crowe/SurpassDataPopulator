using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Logging;
using SurpassDataPopulator.Application.Common.Progress;
using SurpassDataPopulator.Application.Interfaces.Services;
using SurpassDataPopulator.Domain.Authentication;

namespace SurpassDataPopulator.Application.Authentication.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginCommandResult>
{
    private ICredentialsStore _credentialsStore;
    private ILogger<LoginCommandHandler> _logger;
    private ISurpassApiServiceFactory _surpassApiServiceFactory;
    private IProgressContext _progressContext;

    public LoginCommandHandler(
        ICredentialsStore credentialsStore, 
        ISurpassApiServiceFactory surpassApiServiceFactory, 
        ILogger<LoginCommandHandler> logger,
        IProgressContext progressContext)
    {
        _surpassApiServiceFactory = surpassApiServiceFactory;
        _logger = logger;
        _credentialsStore = credentialsStore;
        _progressContext = progressContext;
    }

    public async Task<LoginCommandResult> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var surpassUrl = request.Url;

        //ensure the url doesn't end with a trailing slash
        if (surpassUrl.EndsWith("//"))
        {
            surpassUrl = surpassUrl[..^2];
        }
        if (surpassUrl.EndsWith("/"))
        {
            surpassUrl = surpassUrl[..^1];
        }

        //ensure the url has the /api/v2 at the end
        if (!surpassUrl.EndsWith("/api/v2"))
        {
            surpassUrl += "/api/v2";
        }

        //ensure the url starts with https:// or http:// (http for localhost development)
        if (!surpassUrl.StartsWith("https://") && !surpassUrl.StartsWith("http://"))
        {
            surpassUrl = "https://" + surpassUrl;
        }
        
        var newCredentials = new Credentials
        {
            Url = surpassUrl,
            Username = request.Username,
            Password = request.Password
        };

        _credentialsStore.StageNewCredentials(newCredentials);
        
        try
        {
            await _surpassApiServiceFactory.GetService().TestConnection();
        }
        catch (Exception e)
        {
            _logger.LogError(e, $"Login failed for {newCredentials.Username} @ {surpassUrl}. Please check credentials and retry");
            
            var uri = new Uri(surpassUrl);
            return LoginCommandResult.CreateFailure(
                newCredentials.Username, 
                uri.Host, 
                "Please check credentials and host url and retry", 
                e);
        }

        _credentialsStore.Save(newCredentials);

        var successUri = new Uri(surpassUrl);
        _logger.LogInformation($"{newCredentials.Username} is now logged in to {successUri.Host}. Subsequent commands will use these credentials. Use \"Logout\" to remove them.");

        return LoginCommandResult.CreateSuccess(
            newCredentials.Username,
            successUri.Host,
            surpassUrl);
    }
}