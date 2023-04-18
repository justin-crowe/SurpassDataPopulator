using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.AnalyticsScaleScoreMappingResult;
using SurpassApiSdk.DataContracts.HistoricalResult;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.AnalyticsResult
{
    /// <summary>
    /// Represents a <see cref="AnalyticsResultDetailedResource"/> for get single response./>
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.AnalyticsResult, Namespace = "")]
    [ControllerName(ApiConsts.Segments.AnalyticsResult, 2)]
    public class AnalyticsResultDetailedResource : BaseResultDetailedResource
    {
        [DataMember(Name = ApiConsts.Members.HistoricalResults)]
        public List<HistoricalResultResource> HistoricalResults { get; set; }

        [DataMember(Name = ApiConsts.Members.Pass)]
        public override bool Pass { get; set; }

        [DataMember(Name = ApiConsts.Members.ChangeDetails)]
        public ChangeDetails ChangeDetails { get; set; }

        [DataMember(Name = ApiConsts.Members.ScaleScoreMapping)]
        public AnalyticsScaleScoreMappingLinkedResource AnalyticsScaleScoreMapping { get; set; }
    }
}
