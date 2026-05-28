using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.ItemOptionList, Namespace = "")]
public class EOItemOptionListUpdateResource : ItemOptionListUpdateResource
{
    [CollectionSize(2)]
    [DataMember(Name = ApiConsts.Members.Options, EmitDefaultValue = true)]
    public override IEnumerable<ItemOptionUpdateResource> Options { get; set; }
}