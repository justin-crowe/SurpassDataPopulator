using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Response
{
    /// <summary>
    /// Represents a response with ServerTimeZone property for a post request
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    public class TimeZonePostResponseModel : PostResponseModel, ITimeZoneResponse
    {
        [DataMember(Name = ApiConsts.Members.ServerTimeZone, Order = 5)]
        public string ServerTimeZone { get; set; }
    }
}
