using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.Response;

[DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
public class SingleObjectResponse<T> : IResponse
{
    [DataMember(Name = ApiConsts.Members.Value, Order = 1)]
    public T Value { get; set; }

    [DataMember(Name = ApiConsts.Members.Errors, Order = 2)]
    public IEnumerable<ApiHttpError> Errors { get; set; }
}