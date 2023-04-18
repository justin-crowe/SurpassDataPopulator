using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules
{
    [KnownType("KnownTypes")]
    [DataContract(Namespace = "")]
    public class RescoredItemResource
    {
        [DataMember(Name = ApiConsts.Members.ItemId, Order = 10)]
        public string ItemId { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemVersion, Order = 20)]
        public int ItemVersion { get; set; }

        [DataMember(Name = ApiConsts.Members.Type, Order = 30)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemTypeKey ItemType { get; set; }

        [DataMember(Name = ApiConsts.Members.UnattemptedMark, Order = 99)]
        public int? UnattemptedMark { get; set; }

        [DataMember(Name = ApiConsts.Members.QuestionText, Order = 40)]
        public string ItemQuestionText { get; set; }

        [DataMember(Name = ApiConsts.Members.TotalMark, Order = 50)]
        public int TotalMark { get; set; }

        [DataMember(Name = ApiConsts.Members.ContentType, Order = 60)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemQuestionContentType ItemQuestionContentType { get; set; }

        // This method returns the array of known types.
        // Do not delete this method. It needed to embed information about inherited types into xml to allow xml client to deserialize to particular type.
        private static Type[] KnownTypes()
        {
            return new[] { typeof(RescoredMultipleResponseItemResource), typeof(RescoredQuestionItemResource) };
        }
    }
}
