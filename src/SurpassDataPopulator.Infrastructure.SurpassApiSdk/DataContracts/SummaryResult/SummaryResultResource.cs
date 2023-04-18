using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.SummaryResult
{
    /// <summary>
    /// Represents a <see cref="SummaryResultResource"/> for get many response./>
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.SummaryResult, Namespace = "")]
    [ControllerName(ApiConsts.Segments.SummaryResult, 2)]
    public class SummaryResultResource : LinkedResource
    {
    }
}
