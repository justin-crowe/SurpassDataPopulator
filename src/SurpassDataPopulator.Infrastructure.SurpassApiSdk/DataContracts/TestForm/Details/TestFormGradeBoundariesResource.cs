using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.TestForm.Enums;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm.Details
{
    [ControllerName(ApiConsts.Segments.TestForm, 2)]
    [DataContract(Name = ApiConsts.Contracts.GradeBoundaries, Namespace = "")]
    public class TestFormGradeBoundariesResource
    {
        [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true, Order = 1)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public GradeBoundariesType Type { get; set; }

        [DataMember(Name = ApiConsts.Members.IrtRangeLower, EmitDefaultValue = true, Order = 2)]
        public double IrtRangeLower { get; set; }

        [DataMember(Name = ApiConsts.Members.IrtRangeHigher, EmitDefaultValue = true, Order = 3)]
        public double IrtRangeHigher { get; set; }

        [DataMember(Name = ApiConsts.Members.Boundaries, EmitDefaultValue = true, Order = 4)]
        public List<TestFormGradeBoundaryResource> Boundaries { get; set; }
    }
}
