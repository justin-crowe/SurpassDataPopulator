using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports;

[DataContract(Name = ApiConsts.Contracts.CustomReportManagement, Namespace = "")]
public class CustomReportResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = true)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Reference, Order = 1, EmitDefaultValue = true)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.Name, Order = 2, EmitDefaultValue = true)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportEntities, Order = 3, EmitDefaultValue = false)]
    public string Entities { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportCreationDate, Order = 4, EmitDefaultValue = false)]
    public DateTime CreationDate { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportTemplatingEngine, Order = 5, EmitDefaultValue = false)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public CustomReportTemplatingEngineType TemplatingEngine { get; set; }
}