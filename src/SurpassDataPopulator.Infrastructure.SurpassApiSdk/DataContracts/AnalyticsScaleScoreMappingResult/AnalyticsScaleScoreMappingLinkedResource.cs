using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ScaleScoreMapping;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.AnalyticsScaleScoreMappingResult
{
    /// <summary>
    /// Represents a <see cref="AnalyticsScaleScoreMappingLinkedResource"/> for get single response./>
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.AnalyticsScaleScoreMapping, Namespace = "")]
    [ControllerName(ApiConsts.Segments.AnalyticsScaleScoreMapping, 2)]
    public class AnalyticsScaleScoreMappingLinkedResource : ScaleScoreMappingLinkedResource
    {
    }
}
