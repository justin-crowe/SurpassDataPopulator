using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Comment;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.ItemList;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Interfaces.DataContracts;

namespace SurpassApiSdk.DataContracts.ItemSet;

[ControllerName(ApiConsts.Segments.ItemSet, 2)]
[DataContract(Name = ApiConsts.Contracts.ItemSet, Namespace = "")]
public class ItemSetResource : LinkedResource, ICommentedEntity
{
    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Subject)]
    public SubjectLinkedResource Subject { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.ParentFolderId, EmitDefaultValue = true)]
    public long ParentFolderId { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Position, EmitDefaultValue = true)]
    public int Position { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false)]
    public string Name { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Deleted, EmitDefaultValue = false)]
    public bool Deleted { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.AllowRandomisation, EmitDefaultValue = false)]
    public bool? AllowRandomisation { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.ChildrenLocked, EmitDefaultValue = false)]
    public bool? ChildrenLocked { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Items, EmitDefaultValue = false)]
    public List<ItemLinkedResource> Items { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.SharedWith)]
    public List<SubjectLinkedResource> SharedWith { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.StandardLists)]
    public List<ItemListResource> StandardLists { get; set; }

    [DataMember(Name = ApiConsts.Members.SourceMaterials, EmitDefaultValue = true)]
    public IEnumerable<MediaItemDetailResource> SourceMaterials { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Owner)]
    public UserResource Owner { get; set; }

    [DataMember(Name = ApiConsts.Members.Comment, EmitDefaultValue = true)]
    public string Comment { get; set; }

    [DataMember(Name = ApiConsts.Members.Comments)]
    public List<CommentResource> Comments { get; set; }

    [DataMember(Name = ApiConsts.Members.Language, EmitDefaultValue = true)]
    public LanguageResource Language { get; set; }

    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.LanguageVariants, EmitDefaultValue = true)]
    public virtual IEnumerable<LanguageVariantResource> LanguageVariants { get; set; }
}