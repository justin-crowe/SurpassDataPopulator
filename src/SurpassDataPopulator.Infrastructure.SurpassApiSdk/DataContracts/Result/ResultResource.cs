using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Result;

/// <summary>
/// Represents a <see cref="ResultResource"/> for get many response./>
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Result, Namespace = "")]
[ControllerName(ApiConsts.Segments.Result, 2)]
public class ResultResource : LinkedResource
{
}