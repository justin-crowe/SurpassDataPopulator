using System;
using SurpassDataPopulator.Domain.Common.Progress;

namespace SurpassDataPopulator.Application.Common.Progress;

public interface IProgressContext
{
    IProgress<ProgressReport>? Progress { get; }
    bool IsProgressAvailable { get; }
}
