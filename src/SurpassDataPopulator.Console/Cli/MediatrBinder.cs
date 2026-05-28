using System.CommandLine.Binding;
using MediatR;

namespace SurpassDataPopulator.Console.Cli;

public class MediatrBinder : BinderBase<ISender>
{
    private readonly IMediator _mediator;

    public MediatrBinder(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected override ISender GetBoundValue(BindingContext bindingContext) => GetMediatr(bindingContext);

    ISender GetMediatr(BindingContext bindingContext)
    {
        return _mediator;
    }
}