using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.TagCategory;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagGroup;

[DataContract(Name = ApiConsts.Contracts.TagGroup, Namespace = "")]
public class TagGroupDetailedResource : TagGroupResource
{
    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
    public SubjectLinkedResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.AuthorCreation, EmitDefaultValue = true)]
    public bool AuthorCreation { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowMultipleTags, EmitDefaultValue = true)]
    public bool AllowMultipleTags { get; set; }

    [DataMember(Name = ApiConsts.Members.ReadonlyTagGroup, EmitDefaultValue = true)]
    public bool Readonly { get; set; }

    [DataMember(Name = ApiConsts.Members.IsCollectable, EmitDefaultValue = true)]
    public bool IsCollectable { get; set; }

    [DataMember(Name = ApiConsts.Members.IsPublishable, EmitDefaultValue = true)]
    public bool IsPublishable { get; set; }

    [DataMember(Name = ApiConsts.Members.TagCategories, EmitDefaultValue = true)]
    public List<TagCategoryResource> TagCategories { get; set; }
}