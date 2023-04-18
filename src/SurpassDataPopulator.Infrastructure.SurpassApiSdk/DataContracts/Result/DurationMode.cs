using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result
{
    public enum DurationMode
    {
        [EnumMember(Value = ApiConsts.Members.Untimed)]
        Untimed = 0,

        [EnumMember(Value = ApiConsts.Members.Timed)]
        Timed = 1,

        [EnumMember(Value = ApiConsts.Members.TimedSections)]
        TimedSections = 2
    }
}
