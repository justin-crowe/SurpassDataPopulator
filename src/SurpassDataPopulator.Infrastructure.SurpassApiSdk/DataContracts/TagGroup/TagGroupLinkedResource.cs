using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagGroup;

[ControllerName(ApiConsts.Segments.TagGroup, 2)]
[DataContract(Name = ApiConsts.Contracts.TagGroup, Namespace = "")]
public class TagGroupLinkedResource : LinkedIdResource
{
}