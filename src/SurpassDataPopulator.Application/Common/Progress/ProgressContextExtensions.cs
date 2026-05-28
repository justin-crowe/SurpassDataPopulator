using System;
using SurpassDataPopulator.Domain.Common.Progress;

namespace SurpassDataPopulator.Application.Common.Progress;

public static class ProgressContextExtensions
{
    /// <summary>
    /// Report a simple status message if progress is available
    /// </summary>
    public static void ReportStatus(this IProgressContext context, string status)
    {
        context.Progress?.Report(ProgressReport.CreateSimple(status));
    }

    /// <summary>
    /// Report progress with current and total counts
    /// </summary>
    public static void ReportProgress(this IProgressContext context, string status, int current, int total)
    {
        context.Progress?.Report(ProgressReport.CreateWithCount(status, current, total));
    }

    /// <summary>
    /// Report status with additional contextual information
    /// </summary>
    public static void ReportStatusWithInfo(this IProgressContext context, string status, string additionalInfo)
    {
        context.Progress?.Report(ProgressReport.Create(status, additionalInfo: additionalInfo));
    }
}
