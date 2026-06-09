using MediatR;
using Microsoft.Extensions.Logging;
using SurpassDataPopulator.Application.Common.Progress;
using SurpassDataPopulator.Application.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace SurpassDataPopulator.Application.Authentication.Logout;

public class LogoutCommandHandler : IRequestHandler<LogoutCommand, LogoutCommandResult>
{
    private ICredentialsStore _credentialsStore;
    private ILogger<LogoutCommandHandler> _logger;
    private IProgressContext _progressContext;

    public LogoutCommandHandler(
        ICredentialsStore credentialsStore, 
        ILogger<LogoutCommandHandler> logger,
        IProgressContext progressContext)
    {
        _logger = logger;
        _credentialsStore = credentialsStore;
        _progressContext = progressContext;
    }

    public Task<LogoutCommandResult> Handle(LogoutCommand request, CancellationToken cancellationToken)
    {
        var currentCredentials = _credentialsStore.Load();

        if (currentCredentials == null)
        {
            return Task.FromResult(LogoutCommandResult.CreateNotLoggedIn(null));
        }

        var username = currentCredentials.Username;
        
        _credentialsStore.Delete();
        _logger.LogInformation("Logged out of Surpass.");
        
        var result = string.IsNullOrEmpty(username)
            ? LogoutCommandResult.CreateNotLoggedIn(username)
            : LogoutCommandResult.CreateSuccess(username);
            
        return Task.FromResult(result);
    }
}
