using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ScaleScoreMapping
{
    [DataContract(Name = ApiConsts.Contracts.ScaleScoreMapping, Namespace = "")]
    [ControllerName(ApiConsts.Segments.ScaleScoreMapping, 2)]
    public class ScaleScoreMappingItemResource
    {
        [DataMember(Name = ApiConsts.Members.RawScore, EmitDefaultValue = true, Order = 3)]
        public decimal RawScore { get; set; }

        [DataMember(Name = ApiConsts.Members.ScaleScore, EmitDefaultValue = true, Order = 4)]
        public decimal ScaleScore { get; set; }
    }
}
