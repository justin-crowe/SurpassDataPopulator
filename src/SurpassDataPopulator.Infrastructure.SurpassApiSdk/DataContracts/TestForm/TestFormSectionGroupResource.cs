using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm;

[ControllerName(ApiConsts.Segments.Item, 2)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class TestFormSectionGroupResource : TestFormSectionItemBaseResource
{
    [DataMember(Name = ApiConsts.Members.Group, EmitDefaultValue = false, Order = 1)]
    public TestFormSectionGroupItemResource Group { get; set; }
}