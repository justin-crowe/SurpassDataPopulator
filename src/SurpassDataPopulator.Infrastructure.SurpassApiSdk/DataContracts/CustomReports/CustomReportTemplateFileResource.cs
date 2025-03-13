using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports;

[DataContract(Name = ApiConsts.Contracts.CustomReportManagement, Namespace = "")]
public class CustomReportTemplateFileResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public int Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportTemplateUrl, EmitDefaultValue = true)]
    public string Url { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportTemplatePath, EmitDefaultValue = true)]
    public string TempPath { get; set; }
}