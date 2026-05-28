using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.RescoringRules.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Name = ApiConsts.Contracts.RescoringRule, Namespace = "")]
public class RescoringRuleItemDetailedResourceBase
{
    [DataMember(Name = ApiConsts.Members.ChangeAction)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ChangeActionKeys ChangeAction { get; set; }
}