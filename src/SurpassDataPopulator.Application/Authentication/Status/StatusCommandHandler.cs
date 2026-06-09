using MediatR;
using SurpassDataPopulator.Application.Interfaces.Services;
using System.Threading;
using System.Threading.Tasks;

namespace SurpassDataPopulator.Application.Authentication.Status;

public class StatusCommandHandler : IRequestHandler<StatusCommand, StatusCommandResult>
{
    private ICredentialsStore _credentialsStore;

    public StatusCommandHandler(ICredentialsStore credentialsStore)
    {
        _credentialsStore = credentialsStore;
    }

    public Task<StatusCommandResult> Handle(StatusCommand request, CancellationToken cancellationToken)
    {
        var currentCredentials = _credentialsStore.Load();

        return Task.FromResult(
            currentCredentials == null ?
                StatusCommandResult.CreateNoCredentials() :
                StatusCommandResult.CreateSuccess(currentCredentials.Username, currentCredentials.Url));
    }
}
