using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemList;

[BetaResource]
[ControllerName(ApiConsts.Segments.ItemList, 2)]
[DataContract(Name = ApiConsts.Contracts.ItemList, Namespace = "")]
public class ItemListCreateResource : ReferenceResource
{
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject)]
    public Resource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.Publishable)]
    public bool Publishable { get; set; }

    [DataMember(Name = ApiConsts.Members.Items)]
    public List<Resource> Items { get; set; }
}