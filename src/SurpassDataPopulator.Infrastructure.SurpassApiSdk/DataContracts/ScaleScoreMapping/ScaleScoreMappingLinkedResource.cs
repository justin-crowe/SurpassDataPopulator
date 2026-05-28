using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ScaleScoreMapping;

[ControllerName(ApiConsts.Segments.ScaleScoreMapping, 2)]
[DataContract(Name = ApiConsts.Contracts.ScaleScoreMapping, Namespace = "")]
public class ScaleScoreMappingLinkedResource : LinkedResource
{
}