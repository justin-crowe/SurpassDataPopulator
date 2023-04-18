using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseMultipleChoiceResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.OptionList, EmitDefaultValue = false)]
        public List<ItemResponseOptions> OptionList { get; set; }

        [DataMember(Name = ApiConsts.Members.MarkType, Order = 1, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MarkTypeKey MarkType { get; set; }
    }
}
