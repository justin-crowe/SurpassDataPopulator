using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm
{
    [ControllerName(ApiConsts.Segments.Item, 2)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class TestFormSectionGroupItemResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Items, EmitDefaultValue = false, Order = 2)]
        public List<TestFormSectionItemResource> Items { get; set; }
    }
}
