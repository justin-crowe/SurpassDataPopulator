using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSchedule;

[DataContract(Name = ApiConsts.Members.UnlockOverride, Namespace = "")]
public class UnlockOverrideResource
{
    public const int DaysInAdvanceToUnlockMaxValue = 100;
    public const int DaysAfterToLockMaxValue = 100;

    [DefaultValue(null)]
    [DataMember(Name = ApiConsts.Members.UnlockForWholeDay, Order = 1, IsRequired = false, EmitDefaultValue = true)]
    public bool? UnlockForWholeDay { get; set; }

    [DefaultValue(null)]
    [DataMember(
        Name = ApiConsts.Members.DaysInAdvanceToUnlock,
        Order = 2,
        IsRequired = false,
        EmitDefaultValue = true)]
    public int? DaysInAdvanceToUnlock { get; set; }

    [DefaultValue(null)]
    [DataMember(Name = ApiConsts.Members.DaysAfterToLock, Order = 3, IsRequired = false, EmitDefaultValue = true)]
    public int? DaysAfterToLock { get; set; }
}