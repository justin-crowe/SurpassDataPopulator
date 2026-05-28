using System;
using System.CommandLine.Binding;
using MediatR;

namespace SurpassDataPopulator.Console.Cli;

public class ProgressAwareMediatrBinder : BinderBase<ProgressAwareSender>
{
    private readonly IMediator _mediator;
    private readonly IServiceProvider _serviceProvider;

    public ProgressAwareMediatrBinder(IMediator mediator, IServiceProvider serviceProvider)
    {
        _mediator = mediator;
        _serviceProvider = serviceProvider;
    }

    protected override ProgressAwareSender GetBoundValue(BindingContext bindingContext)
    {
        return new ProgressAwareSender(_mediator, _serviceProvider);
    }
}