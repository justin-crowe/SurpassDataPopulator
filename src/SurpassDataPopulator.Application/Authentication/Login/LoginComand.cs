using MediatR;
using SurpassDataPopulator.Application.Common.Behaviours.Interfaces;

namespace SurpassDataPopulator.Application.Authentication.Login;

public record LoginCommand(string Url, string Username, string Password) : IRequest<LoginCommandResult>, ILoggingBehaviourIgnored;