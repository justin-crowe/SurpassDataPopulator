using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [CollectionSize(1)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class EitherOrItemUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.Randomise, EmitDefaultValue = true)]
        public bool? Randomise { get; set; }

        [DataMember(Name = ApiConsts.Members.AnswerWidthRatio, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AnswerWidthRatio? AnswerWidthRatio { get; set; }

        [DataMember(Name = ApiConsts.Members.OptionList, EmitDefaultValue = true)]
        public EOItemOptionListUpdateResource OptionList { get; set; }
    }
}
