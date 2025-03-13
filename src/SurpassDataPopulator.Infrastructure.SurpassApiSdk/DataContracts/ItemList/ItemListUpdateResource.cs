using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemList;

[ControllerName(ApiConsts.Segments.ItemList, 2)]
[DataContract(Name = ApiConsts.Contracts.ItemList, Namespace = "")]
public class ItemListUpdateResource : ReferenceResource
{
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Publishable, EmitDefaultValue = false)]
    public bool? Publishable { get; set; }

    [DataMember(Name = ApiConsts.Members.Items, EmitDefaultValue = false)]
    public List<Resource> Items { get; set; }
}