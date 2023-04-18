using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TagGroup
{
    [DataContract(Name = ApiConsts.Contracts.TagGroup, Namespace = "")]
    public class TagGroupResource : TagGroupLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.TagTypeKey, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubjectTagTypeKey? TagTypeKey { get; set; } = SubjectTagTypeKey.Custom;

        [DataMember(Name = ApiConsts.Members.TagTypeValue, EmitDefaultValue = false)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TagGroupTagTypeValueKey? TagTypeValue { get; set; }

        [DataMember(Name = ApiConsts.Members.NumericTagProperties, EmitDefaultValue = false)]
        public TagGroupRestrictionsResource NumericTagProperties { get; set; }
    }
}
