using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestSchedule
{
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TestScheduleV2, 2)]
    public class TestSchedulePostResponseModel : TimeZonePostResponseModel
    {
        [DataMember(Name = ApiConsts.Members.Keycode, Order = 5, EmitDefaultValue = false)]
        public string Keycode { get; set; }

        [DataMember(Name = ApiConsts.Members.Pin, Order = 6, EmitDefaultValue = false)]
        public string Pin { get; set; }

        [DataMember(Name = ApiConsts.Members.Candidate, Order = 7, EmitDefaultValue = false)]
        public Resource Candidate { get; set; }
    }
}
