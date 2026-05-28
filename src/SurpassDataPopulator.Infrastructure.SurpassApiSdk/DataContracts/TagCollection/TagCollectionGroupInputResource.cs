using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagCollection;

[DataContract(Name = ApiConsts.Contracts.TagCollectionGroup, Namespace = "")]
[ControllerName(ApiConsts.Segments.TagCollectionGroup, 2)]
public class TagCollectionGroupInputResource : ReferenceResource
{
    [DataMember(Name = ApiConsts.Members.Subject)]
    public SubjectResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.TagGroups)]
    public List<TagGroupIdResource> TagGroups { get; set; }

    [DataMember(Name = ApiConsts.Members.SubCollections, EmitDefaultValue = true)]
    public IEnumerable<TagCollectionGroupResource> SubCollections { get; set; }
}