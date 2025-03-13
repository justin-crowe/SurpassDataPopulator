using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details;

[CollectionSize(1)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class ItemDetailResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public int Id { get; set; }
}