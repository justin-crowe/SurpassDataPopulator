using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm.Details;

[ControllerName(ApiConsts.Segments.TestForm, 2)]
[DataContract(Name = ApiConsts.Contracts.Boundaries, Namespace = "")]
public class TestFormGradeBoundaryResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true, Order = 1)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Value, EmitDefaultValue = true, Order = 2)]
    public double? Value { get; set; }
}