using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Centre;

[ControllerName(ApiConsts.Segments.Centre, 2)]
[DataContract(Name = ApiConsts.Contracts.Centre, Namespace = "")]
public class CentreLinkedResource : LinkedResource
{
}