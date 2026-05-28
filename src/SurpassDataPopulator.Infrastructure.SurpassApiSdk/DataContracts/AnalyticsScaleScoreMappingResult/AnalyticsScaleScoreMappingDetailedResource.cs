using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.ScaleScoreMapping;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.AnalyticsScaleScoreMappingResult;

/// <summary>
/// Represents a <see cref="AnalyticsScaleScoreMappingDetailedResource"/> for get single response./>
/// </summary>
[DataContract(Name = ApiConsts.Contracts.AnalyticsScaleScoreMapping, Namespace = "")]
public class AnalyticsScaleScoreMappingDetailedResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.AnalyticScaleScores, EmitDefaultValue = true)]
    public IEnumerable<ScaleScoreMappingItemResource> ScaleScores { get; set; }
}