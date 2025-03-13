using System.Runtime.Serialization;
using SurpassApiSdk.Helpers;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Report;

[ControllerName(ApiConsts.Segments.Report, 2)]
[DataContract(Name = ApiConsts.Contracts.Report, Namespace = "")]
public class ReportInfoResourceWithParameters : ReportInfoResource
{
    /// <summary>
    /// ParametersCollection
    /// </summary>
    [DataMember(Name = ApiConsts.Members.ReportParameters)]
    public DictionaryXmlSerializable<string, string> ReportParameters { get; set; }
}