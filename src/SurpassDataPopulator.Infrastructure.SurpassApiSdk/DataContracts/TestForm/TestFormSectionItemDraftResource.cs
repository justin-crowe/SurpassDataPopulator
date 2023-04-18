using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm
{
    [ControllerName(ApiConsts.Segments.Item, 2)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class TestFormSectionItemDraftResource : TestFormSectionItemBaseResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.SurpassId, EmitDefaultValue = false, Order = 1)]
        public string SurpassId { get; set; }

        [DataMember(Name = ApiConsts.Members.NonScored, Order = 2)]
        public bool NonScored { get; set; }

        [DataMember(Name = ApiConsts.Members.Group, EmitDefaultValue = false, Order = 3)]
        public TestFormSectionGroupItemResource Group { get; set; }
    }
}
