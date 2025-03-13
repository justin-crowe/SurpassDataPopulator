using System.Runtime.Serialization;

namespace SurpassApiSdk.DataContracts.Item.Enums;

public enum AnswerWidthRatio
{
    [EnumMember(Value = "50/50")]
#pragma warning disable SA1300 // Keep for backward compatibility
    e50and50 = 0,
#pragma warning restore SA1300 // Keep for backward compatibility
    [EnumMember(Value = "20/80")]
#pragma warning disable SA1300 // Keep for backward compatibility
    e20and80 = 1,
#pragma warning restore SA1300 // Keep for backward compatibility
    [EnumMember(Value = "80/20")]
#pragma warning disable SA1300 // Keep for backward compatibility
    e80and20 = 2
#pragma warning restore SA1300 // Keep for backward compatibility
}