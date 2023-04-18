using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test.Details
{
    [DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
    public class TestStyleProfileResource
    {
        [DataMember(Name = ApiConsts.Members.TestProfile, EmitDefaultValue = true)]
        public TestTestProfileResource TestProfile { get; set; }

        [DataMember(Name = ApiConsts.Members.DisplayReport, EmitDefaultValue = true)]
        public bool? DisplayReport { get; set; }

        [DataMember(Name = ApiConsts.Members.DisplayReportPrintButton, EmitDefaultValue = true)]
        public bool? DisplayReportPrintButton { get; set; }
    }
}
