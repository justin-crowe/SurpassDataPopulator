using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class MultipleResponseItemResource
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

        [DataMember(Name = ApiConsts.Members.Combinations, EmitDefaultValue = true, Order = 6)]
        public IEnumerable<CombinationResource> Combinations { get; set; }

        [DataMember(Name = ApiConsts.Members.MaxSelections, EmitDefaultValue = true, Order = 7)]
        public int? MaxSelections { get; set; }

        [DataMember(Name = ApiConsts.Members.PartialMarks, EmitDefaultValue = true, Order = 8)]
        public bool? PartialMarks { get; set; }

        [DataMember(Name = ApiConsts.Members.TableOptionsHtml, Order = 9)]
        public string TableOptionsHtml { get; set; }

        [DataMember(Name = ApiConsts.Members.ExclusiveOptionEnabled, Order = 10, EmitDefaultValue = true)]
        public bool ExclusiveOptionEnabled { get; set; }
    }
}
