using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseEitherOrQuestionResource : ItemResponseBaseResource
{
    [DataMember(Name = ApiConsts.Members.OptionList, Order = 0, EmitDefaultValue = false)]
    public List<ItemResponseEitherOrOptions> OptionList { get; set; }
}