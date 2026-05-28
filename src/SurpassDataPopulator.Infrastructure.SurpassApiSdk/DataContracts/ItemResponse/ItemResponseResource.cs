using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemResponse, 2)]
public class ItemResponseResource : LinkedResource
{
    /// <summary>
    /// Resource Href
    /// </summary>
    [DataMember(Name = ApiConsts.Members.ItemId, Order = 3)]
    [NotSortable]
    [NotFilterable]
    public string ItemId { get; set; }
}