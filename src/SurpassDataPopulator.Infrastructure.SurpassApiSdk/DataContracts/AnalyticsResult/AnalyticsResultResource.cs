using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.AnalyticsResult
{
    [ControllerName(ApiConsts.Segments.AnalyticsResult, 2)]
    [DataContract(Name = ApiConsts.Contracts.AnalyticsResult, Namespace = "")]
    public class AnalyticsResultResource : LinkedResource
    {
    }
}
