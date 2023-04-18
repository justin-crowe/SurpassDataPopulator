using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSchedule
{
    [DataContract]
    public class ReasonableAdjustmentsResource
    {
        [DataMember(Name = ApiConsts.Members.ExtraTimeMinutes, Order = 1)]
        public int? ExtraTimeMinutes { get; set; }

        [DataMember(Name = ApiConsts.Members.ExtraTimePercentage, Order = 2)]
        public int? ExtraTimePercentage { get; set; }

        [DataMember(Name = ApiConsts.Members.Reason, Order = 3)]
        public string Reason { get; set; }
    }
}
