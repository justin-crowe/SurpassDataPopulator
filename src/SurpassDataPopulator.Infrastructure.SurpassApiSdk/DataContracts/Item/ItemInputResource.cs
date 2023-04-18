using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    [ControllerName(ApiConsts.Segments.Item, 2)]
    public class ItemInputResource : BaseItemResource
    {
        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = true, Order = 2)]
        public ItemSubjectResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemType, EmitDefaultValue = true, Order = 1)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemKind ItemKind { get; set; }

        [DataMember(Name = ApiConsts.Members.AssistiveMedia, EmitDefaultValue = true, Order = 3)]
        public AssistiveMediaInputResource AssistiveMedia { get; set; }

        [DataMember(Name = ApiConsts.Members.Language, EmitDefaultValue = true)]
        public LanguageCodeResource Language { get; set; }

        /// <summary>
        /// For internal usage
        /// </summary>
        public int? LanguageParentId { get; set; }
    }
}
