using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemResponse, 2)]
public class ItemResponseLinkedResource : LinkedIdResource
{
}