using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.RescoringRules;

/// <summary>
/// Represents a <see cref="RescoringRuleDetailedResource"/> to get single rule./>
/// </summary>
[DataContract(Name = ApiConsts.Contracts.RescoringRule, Namespace = "")]
[ControllerName(ApiConsts.Segments.RescoringRule, 2)]
public class RescoringRuleDetailedResource : RescoringRuleDetailedResourceBase
{
    [DataMember(Name = ApiConsts.Members.RescoredItems)]
    public List<RescoringRuleItemDetailedResource> RescoredItems { get; set; }
}