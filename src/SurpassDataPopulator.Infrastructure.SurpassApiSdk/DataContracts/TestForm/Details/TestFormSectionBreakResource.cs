using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm.Details
{
    [ControllerName(ApiConsts.Segments.TestForm, 2)]
    [DataContract(Name = ApiConsts.Contracts.SectionBreak, Namespace = "")]
    public class TestFormSectionBreakResource
    {
        [DataMember(Name = ApiConsts.Members.EnableBreak, EmitDefaultValue = true, Order = 1)]
        public bool EnableBreak { get; set; }

        [DataMember(Name = ApiConsts.Members.BreakDuration, EmitDefaultValue = true, Order = 2)]
        public int BreakDuration { get; set; }

        [DataMember(Name = ApiConsts.Members.Cancellable, EmitDefaultValue = true, Order = 3)]
        public bool Cancellable { get; set; }
    }
}
