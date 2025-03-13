using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.SummaryResult;

/// <summary>
/// Represents a <see cref="SummaryResultDetailedResource"/> for get single response./>
/// </summary>
[DataContract(Name = ApiConsts.Contracts.SummaryResult, Namespace = "")]
[ControllerName(ApiConsts.Segments.SummaryResult, 2)]
public class SummaryResultDetailedResource : BaseResultResource
{
    [DataMember(Name = ApiConsts.Members.Test)]
    public LinkedResource Test { get; set; }

    [DataMember(Name = ApiConsts.Members.TestForm)]
    public LinkedResource TestForm { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject)]
    public LinkedResource Subject { get; set; }
}