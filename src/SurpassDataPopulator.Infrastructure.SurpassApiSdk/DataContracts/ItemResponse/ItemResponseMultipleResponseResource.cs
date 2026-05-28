using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseMultipleResponseResource : ItemResponseBaseResource
{
    [DataMember(Name = ApiConsts.Members.Combinations, EmitDefaultValue = false)]
    public List<ItemResponseMultipleResponseCombinations> Combinations { get; set; }

    [DataMember(Name = ApiConsts.Members.PartialMarks, EmitDefaultValue = true)]
    public bool PartialMarks { get; set; }

    [DataMember(Name = ApiConsts.Members.MaxSelections, EmitDefaultValue = false)]
    public int? MaxNumberOfSelections { get; set; }

    [DataMember(Name = ApiConsts.Members.MinSelections, EmitDefaultValue = false)]
    public int? MinNumberOfSelections { get; set; }

    [DataMember(Name = ApiConsts.Members.OptionList, EmitDefaultValue = false)]
    public List<ItemMultipleResponseOptions> OptionList { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkType, Order = 1, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public MarkTypeKey MarkType { get; set; }
}