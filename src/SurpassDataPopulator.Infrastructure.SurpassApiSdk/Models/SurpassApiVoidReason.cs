namespace SurpassApiSdk.Models;

public enum SurpassApiVoidReason
{
    Auto = 0,
    Absent = 1,
    Withdrawn = 2,
    PartiallyCompleted = 3,
    Other = 4,
    NotYetStarted = -1,
}