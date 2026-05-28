using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class ItemLinkedResourceWithSubject : ItemLinkedResource
{
    [DataMember(Name = ApiConsts.Members.Subject, Order = 3)]
    public SubjectLinkedResource Subject { get; set; }
}