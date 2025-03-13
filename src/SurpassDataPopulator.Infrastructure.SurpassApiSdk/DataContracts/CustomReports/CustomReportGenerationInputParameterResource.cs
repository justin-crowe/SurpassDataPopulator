using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports;

[DataContract]
public class CustomReportGenerationInputParameterResource
{
    [DataMember(Name = ApiConsts.Members.CustomReportEntityKey, Order = 0, EmitDefaultValue = false)]
    public string EntityKey { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomReportEntityValues, Order = 1, EmitDefaultValue = false)]
    public IEnumerable<string> Values { get; set; }
}