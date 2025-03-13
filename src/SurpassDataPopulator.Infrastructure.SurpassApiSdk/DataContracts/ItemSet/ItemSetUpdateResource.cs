using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemSet;

[DataContract(Name = ApiConsts.Contracts.ItemSet, Namespace = "")]
public class ItemSetUpdateResource
{
    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Name, Order = 0, EmitDefaultValue = false)]
    public string Name { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.ParentFolderId, EmitDefaultValue = false)]
    public long? ParentFolderId { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Position, EmitDefaultValue = false)]
    public int? Position { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.AllowRandomisation, EmitDefaultValue = false)]
    public bool? AllowRandomisation { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.ChildrenLocked, EmitDefaultValue = false)]
    public bool? ChildrenLocked { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Items, EmitDefaultValue = false)]
    public IList<ItemLinkedResourceBase> Items { get; set; }

    [DataMember(Name = ApiConsts.Members.SourceMaterials, EmitDefaultValue = true)]
    public IEnumerable<MediaItemDetailResource> SourceMaterials { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Owner, EmitDefaultValue = true)]
    public ItemOwnerResource Owner { get; set; }

    [DataMember(Name = ApiConsts.Members.Comment)]
    public string Comment { get; set; }

    [DataMember(Name = ApiConsts.Members.PrivateComment)]
    public bool CommentIsPrivate { get; set; }

    /// <summary>
    /// For internal usage
    /// </summary>
    public int? LanguageParentId { get; set; }
}