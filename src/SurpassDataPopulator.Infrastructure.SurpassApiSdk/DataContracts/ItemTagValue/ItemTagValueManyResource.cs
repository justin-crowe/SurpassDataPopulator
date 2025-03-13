using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemTagValue;

[ControllerName(ApiConsts.Segments.ItemTagValue, 2)]
[DataContract(Name = ApiConsts.Contracts.ItemTagValue, Namespace = "")]
public class ItemTagValueManyResource : Resource
{
}