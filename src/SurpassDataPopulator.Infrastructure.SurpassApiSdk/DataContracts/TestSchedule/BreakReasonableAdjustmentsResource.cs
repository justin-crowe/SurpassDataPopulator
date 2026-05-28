using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSchedule;

[DataContract(Name = ApiConsts.Members.BreakReasonableAdjustments, Namespace = "")]
public class BreakReasonableAdjustmentsResource
{
    [DefaultValue(0)]
    [DataMember(Name = ApiConsts.Members.ExtraTimeMinutes, Order = 1)]
    public int? ExtraTimeMinutes { get; set; }

    [DefaultValue(0)]
    [DataMember(Name = ApiConsts.Members.ExtraTimePercentage, Order = 2)]
    public int? ExtraTimePercentage { get; set; }

    [DefaultValue(0)]
    [DataMember(Name = ApiConsts.Members.NumberOfExtraBreaksPerSection, Order = 3)]
    public int? NumberOfExtraBreaksPerSection { get; set; }

    [DataMember(Name = ApiConsts.Members.Reason, Order = 4)]
    public string Reason { get; set; }
}