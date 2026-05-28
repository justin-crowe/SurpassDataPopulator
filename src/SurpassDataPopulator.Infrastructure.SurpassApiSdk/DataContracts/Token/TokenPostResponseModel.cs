using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Token;

[DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
[ControllerName(ApiConsts.Segments.TestScheduleV2, 2)]
public class TokenPostResponseModel : TimeZonePostResponseModel
{
    [DataMember(Name = ApiConsts.Members.Keycode, Order = 6)]
    public string Keycode { get; set; }
}