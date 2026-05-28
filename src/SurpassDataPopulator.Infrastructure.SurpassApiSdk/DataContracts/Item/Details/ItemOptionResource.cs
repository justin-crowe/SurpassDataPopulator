using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.ItemOption, Namespace = "")]
public class ItemOptionResource : ItemOptionBaseResource
{
    [DataMember(Name = ApiConsts.Members.AssistiveMedia, EmitDefaultValue = true)]
    public AssistiveMediaLinkedResource AssistiveMedia { get; set; }
}