using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports;

[DataContract]
public class CustomReportInputParameterResource
{
    [DataMember(Name = ApiConsts.Members.CustomReportEntityKey, Order = 0, EmitDefaultValue = false)]
    public string EntityKey { get; set; }
}