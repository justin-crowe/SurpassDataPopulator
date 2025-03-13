using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item;

[ControllerName(ApiConsts.Segments.Item, 2)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class ItemLinkedResource : ItemLinkedResourceBase, ILinkedResource
{
    [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = false, Order = 1)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ItemTypeKey Type { get; set; }

    /// <summary>
    /// Resource Href
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Href, Order = 2)]
    [NotSortable]
    [NotFilterable]
    public string Href { get; set; }
}