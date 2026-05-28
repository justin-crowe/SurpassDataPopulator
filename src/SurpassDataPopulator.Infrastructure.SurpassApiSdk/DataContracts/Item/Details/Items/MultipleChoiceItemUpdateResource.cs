using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[CollectionSize(1)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class MultipleChoiceItemUpdateResource
{
    [DataMember(Name = ApiConsts.Members.AnswerWidthRatio, EmitDefaultValue = true, Order = 1)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public AnswerWidthRatio? AnswerWidthRatio { get; set; }

    [DataMember(Name = ApiConsts.Members.OptionList, EmitDefaultValue = true, Order = 2)]
    public ItemOptionListUpdateResource OptionList { get; set; }

    [DataMember(Name = ApiConsts.Members.Randomise, EmitDefaultValue = true, Order = 3)]
    public bool? Randomise { get; set; }

    [DataMember(Name = ApiConsts.Members.AddLabelsToOptions, EmitDefaultValue = true, Order = 4)]
    public bool? AddLabelsToOptions { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkType, Order = 5)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public MarkTypeKey? MarkType { get; set; }

    [DataMember(Name = ApiConsts.Members.TableOptionsHtml, Order = 6)]
    public string TableOptionsHtml { get; set; }

    [DataMember(Name = ApiConsts.Members.RationaleEnabled, EmitDefaultValue = true, Order = 7)]
    public bool? RationaleEnabled { get; set; }
}