using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Tools
{
    //[JsonConverter(typeof(ItemToolResourceConverter))]
    [DataContract(Name = ApiConsts.Contracts.ItemTool, Namespace = "")]
    [ControllerName(ApiConsts.Segments.ItemTool, 2)]
    public class ItemToolResource
    {
        [DataMember(Name = ApiConsts.Members.Name)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemToolType Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Settings)]
        public ItemToolSettingsBase Settings { get; set; }
    }
}
