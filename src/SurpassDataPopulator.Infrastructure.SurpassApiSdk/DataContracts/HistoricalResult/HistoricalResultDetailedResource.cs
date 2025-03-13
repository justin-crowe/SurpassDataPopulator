using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.AnalyticsScaleScoreMappingResult;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.HistoricalResult;

[DataContract(Name = ApiConsts.Contracts.HistoricalResult, Namespace = "")]
[ControllerName(ApiConsts.Segments.HistoricalResult, 2)]
public class HistoricalResultDetailedResource : BaseResultDetailedResource
{
    [DataMember(Name = ApiConsts.Members.IsLatest)]
    public bool IsLatest { get; set; }

    [DataMember(Name = ApiConsts.Members.Pass)]
    public override bool Pass { get; set; }

    [DataMember(Name = ApiConsts.Members.AdjustedGrade)]
    public string AdjustedGrade { get; set; }

    [DataMember(Name = ApiConsts.Members.ChangeDetails)]
    public ChangeDetails ChangeDetails { get; set; }

    [DataMember(Name = ApiConsts.Members.ScaleScoreMapping)]
    public AnalyticsScaleScoreMappingLinkedResource AnalyticsScaleScoreMapping { get; set; }
}