using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result
{
    [DataContract(Name = ApiConsts.Contracts.ReasonableAdjustments, Namespace = "")]
    public class ResultReasonableAdjustmentsResource
    {
        [DataMember(Name = ApiConsts.Members.TotalTimeAdded)]
        public int TotalTimeAdded { get; set; }

        [DataMember(Name = ApiConsts.Members.ReasonForAdjustment)]
        public string ReasonForAdjustment { get; set; }
    }
}
