using System;
using Spectre.Console;
using SurpassDataPopulator.Domain.Common.Progress;

namespace SurpassDataPopulator.Console.Progress;

public class SpectreProgressReporter : IProgress<ProgressReport>
{
    private readonly StatusContext _statusContext;

    public SpectreProgressReporter(StatusContext statusContext)
    {
        _statusContext = statusContext;
    }

    public void Report(ProgressReport value)
    {
        var statusText = value.CurrentStep.HasValue && value.TotalSteps.HasValue
            ? $"{value.Status} ({value.CurrentStep}/{value.TotalSteps})"
            : value.Status;

        if (!string.IsNullOrEmpty(value.AdditionalInfo))
        {
            statusText += $" - {value.AdditionalInfo}";
        }

        _statusContext.Status(statusText);
    }
}