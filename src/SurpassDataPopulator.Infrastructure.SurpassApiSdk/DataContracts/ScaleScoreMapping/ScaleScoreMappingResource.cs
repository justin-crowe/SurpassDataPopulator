using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ScaleScoreMapping;

[DataContract(Name = ApiConsts.Contracts.ScaleScoreMapping, Namespace = "")]
[ControllerName(ApiConsts.Segments.ScaleScoreMapping, 2)]
public class ScaleScoreMappingResource : LinkedResource
{
}