using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;
using SurpassDataPopulator.Application.Common.Progress;
using SurpassDataPopulator.Console.Progress;
using ProgressContext = SurpassDataPopulator.Application.Common.Progress.ProgressContext;

namespace SurpassDataPopulator.Console.Cli;

public class ProgressAwareSender
{
    private readonly ISender _sender;
    private readonly IServiceProvider _serviceProvider;

    public ProgressAwareSender(ISender sender, IServiceProvider serviceProvider)
    {
        _sender = sender;
        _serviceProvider = serviceProvider;
    }

    public async Task<TResult> SendWithProgressAsync<TResult>(IRequest<TResult> request, string initialStatus = "Processing...")
    {
        return await AnsiConsole.Status()
            .StartAsync(initialStatus, async ctx =>
            {
                var reporter = new SpectreProgressReporter(ctx);
                var progressContext = _serviceProvider.GetRequiredService<IProgressContext>();

                if (progressContext is ProgressContext mutableContext)
                {
                    mutableContext.SetProgress(reporter);
                }

                return await _sender.Send(request);
            });
    }
}