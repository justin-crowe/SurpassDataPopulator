using MediatR;
using SurpassDataPopulator.Application.Common.Behaviours.Interfaces;

namespace SurpassDataPopulator.Application.Authentication.Status;

public record StatusCommand : IRequest<StatusCommandResult>, ILoggingBehaviourIgnored;

