using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagCollection;

[DataContract(Name = ApiConsts.Contracts.TagCollection, Namespace = "")]
public class TagCollectionResource : ReferenceResource
{
    [DataMember(Name = ApiConsts.Members.CollectionGroup, EmitDefaultValue = false)]
    public TagCollectionGroupResource CollectionGroup { get; set; }

    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }
}