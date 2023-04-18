using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Test.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test.Details
{
    [DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
    public class TestScoreBoundariesResource
    {
        [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BoundariesType? Type { get; set; }

        [DataMember(Name = ApiConsts.Members.Boundaries, EmitDefaultValue = true)]
        public TestBoundariesResource[] Boundaries { get; set; }
    }
}
