using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class MultipleChoiceItemResource
{
    [DataMember(Name = ApiConsts.Members.AnswerWidthRatio, EmitDefaultValue = true, Order = 1)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public AnswerWidthRatio? AnswerWidthRatio { get; set; }

    [DataMember(Name = ApiConsts.Members.OptionList, EmitDefaultValue = true, Order = 2)]
    public ItemOptionListResource OptionList { get; set; }

    [DataMember(Name = ApiConsts.Members.Randomise, EmitDefaultValue = true, Order = 3)]
    public bool? Randomise { get; set; }

    [DataMember(Name = ApiConsts.Members.AddLabelsToOptions, EmitDefaultValue = true, Order = 4)]
    public bool? AddLabelsToOptions { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkType, Order = 5)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public MarkTypeKey? MarkType { get; set; }

    [DataMember(Name = ApiConsts.Members.TableOptionsHtml, Order = 6)]
    public string TableOptionsHtml { get; set; }
}