using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.BasicPage
{
    [DataContract(Name = ApiConsts.Contracts.BasicPage, Namespace = "")]
    public class BasicPageInputResource : BasePageResource
    {
        [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemTypeKey? Type { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = true)]
        public ItemSubjectResource Subject { get; set; }
    }
}
