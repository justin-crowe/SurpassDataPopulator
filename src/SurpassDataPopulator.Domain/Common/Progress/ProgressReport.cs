namespace SurpassDataPopulator.Domain.Common.Progress;

public class ProgressReport
{
    public string Status { get; }
    public int? CurrentStep { get; }
    public int? TotalSteps { get; }
    public string AdditionalInfo { get; }

    private ProgressReport(string status, int? currentStep = null, int? totalSteps = null, string additionalInfo = null)
    {
        Status = status;
        CurrentStep = currentStep;
        TotalSteps = totalSteps;
        AdditionalInfo = additionalInfo;
    }

    public static ProgressReport Create(string status, int? currentStep = null, int? totalSteps = null, string additionalInfo = null)
    {
        return new ProgressReport(status, currentStep, totalSteps, additionalInfo);
    }

    public static ProgressReport CreateWithCount(string status, int currentStep, int totalSteps, string additionalInfo = null)
    {
        return new ProgressReport(status, currentStep, totalSteps, additionalInfo);
    }

    public static ProgressReport CreateSimple(string status)
    {
        return new ProgressReport(status);
    }
}
