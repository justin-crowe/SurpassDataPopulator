using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports
{
    [DataContract(Name = ApiConsts.Contracts.GeneratedReport, Namespace = "")]
    public class GeneratedReportResource
    {
        [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
        public string Id { get; set; }

        [DataMember(Name = ApiConsts.Members.CustomReportTemplateUrl, EmitDefaultValue = true)]
        public string ReportUrl { get; set; }
    }
}
