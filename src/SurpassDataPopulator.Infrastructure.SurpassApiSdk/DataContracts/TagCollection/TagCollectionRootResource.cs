using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagCollection;

[DataContract(Name = ApiConsts.Contracts.TagCollection, Namespace = "")]
public class TagCollectionRootResource : TagCollectionResource
{
    [DataMember(Name = ApiConsts.Members.SubCollection, EmitDefaultValue = false)]
    public TagCollectionResource SubCollection { get; set; }

    [DataMember(Name = ApiConsts.Members.IsCurrent)]
    public bool IsCurrent { get; set; }
}