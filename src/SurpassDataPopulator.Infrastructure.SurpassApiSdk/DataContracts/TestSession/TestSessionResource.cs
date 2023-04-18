using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestSession
{
    [DataContract(Name = ApiConsts.Contracts.TestSession, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TestSession, 2)]
    public class TestSessionResource : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.AwaitingMarkingSubmission, EmitDefaultValue = false, Order = 3)]
        public bool? AwaitingMarkingSubmission { get; set; }

        [DataMember(Name = ApiConsts.Members.MarkingProgressPercent, EmitDefaultValue = false, Order = 4)]
        public int? MarkingProgressPercent { get; set; }

        [DataMember(Name = ApiConsts.Members.TestForm, EmitDefaultValue = false, Order = 5)]
        public NamedHrefResource TestForm { get; set; }

        [DataMember(Name = ApiConsts.Members.Test, EmitDefaultValue = false, Order = 6)]
        public NamedHrefResource Test { get; set; }
    }
}
