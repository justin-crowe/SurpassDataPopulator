using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemList;

[ControllerName(ApiConsts.Segments.ItemList, 2)]
[DataContract(Name = ApiConsts.Contracts.ItemList, Namespace = "")]
public class ItemListDetailResource : ItemListResource
{
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject)]
    public SubjectLinkedResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.CreatedBy)]
    public UserResource CreatedBy { get; set; }

    [DataMember(Name = ApiConsts.Members.DateCreated)]
    public DateTime DateCreated { get; set; }

    [DataMember(Name = ApiConsts.Members.Publishable)]
    public bool Publishable { get; set; }

    [DataMember(Name = ApiConsts.Members.IsMaster)]
    public bool IsMaster { get; set; }

    [DataMember(Name = ApiConsts.Members.IsDeleted)]
    public bool IsDeleted { get; set; }

    [DataMember(Name = ApiConsts.Members.Items)]
    public List<ItemLinkedResourceWithSubject> Items { get; set; }
}