using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item;

[ControllerName(ApiConsts.Segments.Item, 2)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class ItemManyResource : Resource
{
}