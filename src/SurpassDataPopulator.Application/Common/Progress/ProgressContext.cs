using System;
using SurpassDataPopulator.Domain.Common.Progress;

namespace SurpassDataPopulator.Application.Common.Progress;

public class ProgressContext : IProgressContext
{
    private IProgress<ProgressReport>? _progress;

    public IProgress<ProgressReport>? Progress => _progress;
    public bool IsProgressAvailable => _progress != null;

    public ProgressContext(IProgress<ProgressReport>? progress = null)
    {
        _progress = progress;
    }

    public void SetProgress(IProgress<ProgressReport> progress)
    {
        _progress = progress;
    }

    public static ProgressContext Empty() => new ProgressContext();
}
