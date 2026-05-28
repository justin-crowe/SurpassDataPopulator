using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ScaleScoreMapping;

[DataContract(Name = ApiConsts.Contracts.ScaleScoreMapping, Namespace = "")]
[ControllerName(ApiConsts.Segments.ScaleScoreMapping, 2)]
public class ScaleScoreMappingDetailedResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.TestFormId, EmitDefaultValue = false)]
    public int TestFormId { get; set; }

    [DataMember(Name = ApiConsts.Members.ScaleScores, EmitDefaultValue = true)]
    public IEnumerable<ScaleScoreMappingItemResource> ScaleScores { get; set; }
}