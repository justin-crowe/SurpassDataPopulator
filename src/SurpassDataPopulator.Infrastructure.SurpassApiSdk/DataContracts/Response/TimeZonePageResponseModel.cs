using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Response;

/// <summary>
/// Represents an expanded <see cref="PageResponse{T}"/> with ServerTimeZone property
/// </summary>
/// <typeparam name="T">Response resource type</typeparam>
[DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
public class TimeZonePageResponseModel<T> : PageResponseModel<T>, ITimeZoneResponse
{
    public TimeZonePageResponseModel()
        : base()
    {
    }

    public TimeZonePageResponseModel(IEnumerable<T> items, long? count)
        : base(items, count)
    {
    }

    public TimeZonePageResponseModel(T result)
        : base(result)
    {
    }

    [DataMember(Name = ApiConsts.Members.ServerTimeZone, Order = 8)]
    public string ServerTimeZone { get; set; }
}