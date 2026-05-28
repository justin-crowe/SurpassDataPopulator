using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.MediaGroup;

[ControllerName(ApiConsts.Segments.MediaGroup, 2)]
[DataContract(Name = ApiConsts.Contracts.Media, Namespace = "")]
public class MediaGroupResource : Resource
{
}