using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details;

[ControllerName(ApiConsts.Segments.AssistiveMedia, 2)]
[DataContract(Name = ApiConsts.Contracts.AssistiveMedia, Namespace = "")]
public class AssistiveMediaLinkedResource : LinkedResource
{
}