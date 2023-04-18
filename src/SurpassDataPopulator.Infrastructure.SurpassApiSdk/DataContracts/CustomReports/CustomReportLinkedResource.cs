using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.CustomReports
{
    [ControllerName(ApiConsts.Segments.CustomReport, 2)]
    [DataContract(Name = ApiConsts.Contracts.CustomReportManagement, Namespace = "")]
    public class CustomReportLinkedResource : LinkedResource
    {
    }
}
