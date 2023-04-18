using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Test.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test.Details
{
    [DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
    public class TestProgressBarResource
    {
        [DataMember(Name = ApiConsts.Members.Required, EmitDefaultValue = true)]
        public bool? Required { get; set; }

        [DataMember(Name = ApiConsts.Members.Mode, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TestProgressBarMode? Mode { get; set; }
    }
}
