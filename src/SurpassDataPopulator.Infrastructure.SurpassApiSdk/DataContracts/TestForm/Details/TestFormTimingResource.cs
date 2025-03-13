using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.DataContracts.TestForm.Enums;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm.Details;

[ControllerName(ApiConsts.Segments.TestForm, 2)]
[DataContract(Name = ApiConsts.Contracts.Timing, Namespace = "")]
public class TestFormTimingResource
{
    [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true, Order = 1)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DurationMode Type { get; set; }

    [DataMember(Name = ApiConsts.Members.TestDuration, EmitDefaultValue = true, Order = 2)]
    public int TestDuration { get; set; }

    [DataMember(Name = ApiConsts.Members.AddBreak, EmitDefaultValue = true, Order = 3)]
    public bool AddBreak { get; set; }

    [DataMember(Name = ApiConsts.Members.AddBreakType, EmitDefaultValue = true, Order = 4)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public BreakType AddBreakType { get; set; }

    [DataMember(Name = ApiConsts.Members.AddBreakPoolDuration, EmitDefaultValue = true, Order = 5)]
    public int AddBreakPoolDuration { get; set; }
}