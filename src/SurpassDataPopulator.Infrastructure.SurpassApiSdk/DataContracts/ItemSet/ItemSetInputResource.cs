using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemSet;

[DataContract(Name = ApiConsts.Contracts.ItemSet, Namespace = "")]
public class ItemSetInputResource : ItemSetUpdateResource
{
    [ConditionalMemberIgnore]
    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
    public SubjectLinkedResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.Language, EmitDefaultValue = true)]
    public LanguageCodeResource Language { get; set; }
}