namespace SurpassApiSdk.DataContracts.RescoringRules.Enums;
#pragma warning disable CA1717 // Keep for backward compatibility
public enum ChangeActionKeys
#pragma warning restore CA1717 // Keep for backward compatibility
{
    None = 0,

    AnswerChanged = 1,

    ScoreAddedAnswerChanged = 2,

    FullMarked = 3,

    ScoreAddedFullMarked = 4,

    FullMarkedUnattempted = 5,

    ScoreAddedFullMarkedUnattempted = 6,

    Deleted = 7,

    Added = 8,

    Reverted = 9
}