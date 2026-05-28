using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Helpers;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Report;

[ControllerName(ApiConsts.Segments.Report, 2)]
[DataContract(Name = ApiConsts.Contracts.Report, Namespace = "")]
public class ReportDataResource : LinkedResource
{
    /// <summary>
    /// Report name
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Data, Order = 6)]
    public CDataWrapper Data { get; set; }
}