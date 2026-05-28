using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagCategory;

[DataContract(Name = ApiConsts.Contracts.TagCategory, Namespace = "")]
[ControllerName(ApiConsts.Segments.TagCategory, 2)]
public class TagCategoryUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.TagGroups)]
    public List<TagGroupIdResource> TagGroups { get; set; }
}