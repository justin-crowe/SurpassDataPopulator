using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Response
{
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    public class TimeZonePageResponse<T> : PageResponse<T>, ITimeZoneResponse
    {
        public TimeZonePageResponse()
        {
        }

        public TimeZonePageResponse(IPageResponse response)
            : base(response)
        {
        }

        [DataMember(Name = ApiConsts.Members.ServerTimeZone, Order = 8)]
        public string ServerTimeZone { get; set; }
    }
}
