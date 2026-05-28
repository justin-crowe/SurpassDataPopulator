using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Section;

[DataContract(Name = ApiConsts.Members.DecisionPoint, Namespace = "")]
public class ResultDecisionPointResource : DecisionPointResource
{
    [DataMember(Name = ApiConsts.Members.Outcome, Order = 5)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ESectionOutcome? Outcome { get; set; }
}