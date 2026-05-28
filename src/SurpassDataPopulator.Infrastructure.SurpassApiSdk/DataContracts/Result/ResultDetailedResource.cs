using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Result.LearningOutcomeAnalysis;
using SurpassApiSdk.DataContracts.ScaleScoreMapping;
using SurpassApiSdk.DataContracts.TestSession;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Result;

/// <summary>
/// Represents a <see cref="ResultDetailedResource"/> for get single response./>
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Result, Namespace = "")]
[ControllerName(ApiConsts.Segments.Result, 2)]
public class ResultDetailedResource : BaseResultDetailedResource
{
    [DataMember(Name = ApiConsts.Members.ScaleScoreMapping)]
    public ScaleScoreMappingLinkedResource ScaleScoreMapping { get; set; }

    [DataMember(Name = ApiConsts.Members.Analysis, EmitDefaultValue = false, Order = 1500)]
    public List<LearningOutcomeAnalysisUnitResource> LearningOutcomeAnalysisUnits { get; set; }

    [DataMember(Name = ApiConsts.Members.Downloads, EmitDefaultValue = false, Order = 1501)]
    public IEnumerable<TestSessionDownloadInfoResource> Downloads { get; set; }
}