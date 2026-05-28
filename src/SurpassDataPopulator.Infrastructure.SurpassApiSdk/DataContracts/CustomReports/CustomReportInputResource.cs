using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports;

[DataContract(Name = ApiConsts.Contracts.CustomReportManagement, Namespace = "")]
public class CustomReportInputResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 0, EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Reference, Order = 1, EmitDefaultValue = false)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportTemplate, Order = 2, EmitDefaultValue = false)]
    public CustomReportFileResource TemplateFile { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportParameters, Order = 3, EmitDefaultValue = false)]
    public IEnumerable<CustomReportInputParameterResource> Parameters { get; set; }
}