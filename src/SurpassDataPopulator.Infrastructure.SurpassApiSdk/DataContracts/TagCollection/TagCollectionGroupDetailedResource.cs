using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TagCollection
{
    [DataContract(Name = ApiConsts.Contracts.TagCollectionGroup, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TagCollectionGroup, 2)]
    public class TagCollectionGroupDetailedResource : TagCollectionGroupLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = true)]
        public SubjectResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.TagGroups, EmitDefaultValue = true)]
        public IEnumerable<TagGroupLinkedResource> TagGroups { get; set; }

        [DataMember(Name = ApiConsts.Members.SubCollections, EmitDefaultValue = true)]
        public IEnumerable<TagCollectionGroupLinkedResource> SubCollections { get; set; }
    }
}
