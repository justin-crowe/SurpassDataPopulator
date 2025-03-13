namespace SurpassApiSdk.Models;

public enum SurpassApiExamState
{
    None = 0,
    ScheduledButNotCreated = 1,
    ScheduledButNotDownloaded = 2,
    ScheduledButLocked = 3,
    Ready = 4,
    LockedForInvigilator = 5,
    InProgress = 6,
    Paused = 7,
    Offline = 8,
    Finished = 9,
    Voided = 10,
    Marked = 11,
    ScriptVerified = 12,
    Archived = 13,
    LockedByPin = 14,
    AwaitingMarking = 15,
    AwaitingVerification = 16,
    AwaitingUpload = 18,
    PaperResponseUpload = 19,
    LocalScanRequested = 20,
    RequiresCheckIn = 22,
    Exception = 99
}