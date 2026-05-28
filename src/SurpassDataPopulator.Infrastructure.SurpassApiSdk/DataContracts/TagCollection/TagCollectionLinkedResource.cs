using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagCollection;

[DataContract(Name = ApiConsts.Contracts.TagCollection, Namespace = "")]
public class TagCollectionLinkedResource : ReferenceResource
{
    [DataMember(Name = ApiConsts.Members.CollectionGroup, EmitDefaultValue = false)]
    public TagCollectionGroupLinkedResource CollectionGroup { get; set; }
}