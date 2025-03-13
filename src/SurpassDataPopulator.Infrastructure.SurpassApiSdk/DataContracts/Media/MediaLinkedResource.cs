using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Media;

[ControllerName(ApiConsts.Segments.Media, 2)]
[DataContract(Name = ApiConsts.Contracts.Media, Namespace = "")]
public class MediaLinkedResource : LinkedResource
{
}