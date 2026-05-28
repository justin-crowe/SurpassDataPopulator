using MediatR;
using SurpassDataPopulator.Application.Common.Behaviours.Interfaces;

namespace SurpassDataPopulator.Application.Authentication.Logout;

public record LogoutCommand() : IRequest<LogoutCommandResult>, ILoggingBehaviourIgnored;