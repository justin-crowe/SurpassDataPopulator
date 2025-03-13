using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.AnalyticsScaleScoreMappingResult;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Name = ApiConsts.Members.ScoringDataItem, Namespace = "")]
[ControllerName(ApiConsts.Segments.RescoringRule, 2)]
public class ScoringDataResource
{
    [DataMember(Name = ApiConsts.Members.TestFormVersion)]
    public long TestFormVersion { get; set; }

    [DataMember(Name = ApiConsts.Members.ScaleScoreMapping)]
    public AnalyticsScaleScoreMappingLinkedResource AnalyticsScaleScoreMapping { get; set; }

    [DataMember(Name = ApiConsts.Members.GradeBoundaries)]
    public GradeBoundaries GradeBoundaries { get; set; }

    [DataMember(Name = ApiConsts.Members.LoBoundaries)]
    public LoBoundaries LearningOutcomeBoundaries { get; set; }
}