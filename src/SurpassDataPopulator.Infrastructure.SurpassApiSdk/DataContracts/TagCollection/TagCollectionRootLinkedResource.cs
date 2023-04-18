using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagCollection
{
    [DataContract(Name = ApiConsts.Contracts.TagCollection, Namespace = "")]
    public class TagCollectionRootLinkedResource : TagCollectionLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.SubCollection, EmitDefaultValue = false)]
        public TagCollectionLinkedResource SubCollection { get; set; }

        [DataMember(Name = ApiConsts.Members.IsCurrent)]
        public bool IsCurrent { get; set; }

        [DataMember(Name = ApiConsts.Members.Name)]
        public string Name { get; set; }
    }
}
