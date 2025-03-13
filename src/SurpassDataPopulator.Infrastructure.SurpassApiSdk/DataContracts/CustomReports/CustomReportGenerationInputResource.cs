using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports;

[DataContract(Name = ApiConsts.Contracts.CustomReportManagement, Namespace = "")]
public class CustomReportGenerationInputResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = false)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Reference, Order = 1, EmitDefaultValue = false)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportParameters, Order = 2, EmitDefaultValue = false)]
    public IEnumerable<CustomReportGenerationInputParameterResource> Params { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportCustomData, Order = 3, EmitDefaultValue = false)]
    public dynamic CustomData { get; set; }
}