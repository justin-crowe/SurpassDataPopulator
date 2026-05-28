using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSchedule;

[DataContract(Name = ApiConsts.Members.UnscheduledBreak, Namespace = "")]
public class UnscheduledBreakResource
{
    [DefaultValue(0)]
    [DataMember(Name = ApiConsts.Members.ExtraTimeMin, Order = 1)]
    public int ExtraTimeMin { get; set; }
}