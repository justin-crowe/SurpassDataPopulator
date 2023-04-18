using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Section
{
    [DataContract(Name = ApiConsts.Contracts.Section, Namespace = "")]
    [ControllerName(ApiConsts.Members.Section, 2)]
    public class SectionWithDecisionPointResource : SectionExtendedResource
    {
        [DataMember(Name = ApiConsts.Members.DecisionPoint, EmitDefaultValue = true, Order = 4)]
        public DecisionPointResource DecisionPoint { get; set; }

        [DataMember(Name = ApiConsts.Members.AdditionalMediaReplays, EmitDefaultValue = true, Order = 5)]
        public AdditionalMediaReplayResource AdditionalMediaReplays { get; set; }
    }
}
