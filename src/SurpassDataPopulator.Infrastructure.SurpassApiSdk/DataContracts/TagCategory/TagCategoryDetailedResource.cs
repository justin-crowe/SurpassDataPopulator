using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagCategory;

[DataContract(Name = ApiConsts.Contracts.TagCategory, Namespace = "")]
[ControllerName(ApiConsts.Segments.TagCategory, 2)]
public class TagCategoryDetailedResource : TagCategoryResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.TagGroups, EmitDefaultValue = true)]
    public IEnumerable<TagGroupLinkedResource> TagGroups { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = true)]
    public SubjectResource Subject { get; set; }
}