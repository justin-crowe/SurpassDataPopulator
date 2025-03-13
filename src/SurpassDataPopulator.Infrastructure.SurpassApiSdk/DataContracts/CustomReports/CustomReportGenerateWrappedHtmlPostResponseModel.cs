using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports;

[DataContract(Name = ApiConsts.Contracts.GeneratedReport, Namespace = "")]
public class CustomReportGenerateWrappedHtmlPostResponseModel
{
    [DataMember(Name = ApiConsts.Members.CustomReportHtml, Order = 1, EmitDefaultValue = true)]
    public string Html { get; set; }
}