using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.ItemOptionList, Namespace = "")]
public class ItemOptionListUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Options, EmitDefaultValue = true)]
    public virtual IEnumerable<ItemOptionUpdateResource> Options { get; set; }
}