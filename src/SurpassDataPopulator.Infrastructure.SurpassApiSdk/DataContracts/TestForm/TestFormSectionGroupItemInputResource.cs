using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm;

[ControllerName(ApiConsts.Segments.Item, 2)]
[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class TestFormSectionGroupItemInputResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 1)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Items, Order = 2)]
    public List<TestFormItemResource> Items { get; set; }
}