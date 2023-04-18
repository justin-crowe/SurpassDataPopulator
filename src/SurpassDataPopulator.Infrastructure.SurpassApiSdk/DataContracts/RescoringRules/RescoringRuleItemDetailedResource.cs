using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.RescoringRules
{
    [DataContract(Name = ApiConsts.Contracts.RescoringRule, Namespace = "")]
    [ControllerName(ApiConsts.Segments.RescoringRule, 2)]
    public class RescoringRuleItemDetailedResource : RescoringRuleItemDetailedResourceBase
    {
        [DataMember(Name = ApiConsts.Members.RescoredItem)]
        public RescoredItemResource RescoredItem { get; set; }
    }
}
