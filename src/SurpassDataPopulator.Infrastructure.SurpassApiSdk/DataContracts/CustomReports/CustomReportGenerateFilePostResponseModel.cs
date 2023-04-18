using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CustomReports
{
    [DataContract(Name = ApiConsts.Contracts.GeneratedReport, Namespace = "")]
    public class CustomReportGenerateFilePostResponseModel : PostResponseModel
    {
        [DataMember(Name = ApiConsts.Members.CustomReport, Order = 1, EmitDefaultValue = true)]
        public GeneratedReportResource Report { get; set; }

        [DataMember(Name = ApiConsts.Members.CustomReportTemplatingEngine, Order = 2, EmitDefaultValue = false)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CustomReportTemplatingEngineType TemplatingEngine { get; set; }
    }
}
