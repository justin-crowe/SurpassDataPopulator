using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class EitherOrItemResource
    {
        [DataMember(Name = ApiConsts.Members.Randomise, EmitDefaultValue = true)]
        public bool? Randomise { get; set; }

        [DataMember(Name = ApiConsts.Members.AnswerWidthRatio, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AnswerWidthRatio? AnswerWidthRatio { get; set; }

        [DataMember(Name = ApiConsts.Members.OptionList, EmitDefaultValue = true)]
        public ItemOptionListResource OptionList { get; set; }
    }
}
