using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestSession
{
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TestScheduleV2, 2)]
    public class TestSessionPostResponseModel : TimeZonePostResponseModel
    {
        [DataMember(Name = ApiConsts.Members.Message, Order = 5)]
        public string Message { get; set; }
    }
}
