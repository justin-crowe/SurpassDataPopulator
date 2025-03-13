using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.HistoricalResult;

[DataContract(Name = ApiConsts.Members.ChangeDetails, Namespace = "")]
public class ChangeDetails
{
    [DataMember(Name = ApiConsts.Members.Type)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ResultChangeType Type { get; set; }

    [DataMember(Name = ApiConsts.Members.DateApplied)]
    public DateTime? DateApplied { get; set; }

    [DataMember(Name = ApiConsts.Members.User)]
    public UserResource User { get; set; }

    [DataMember(Name = ApiConsts.Members.RescoringRules)]
    public ResultResource RescoringRules { get; set; }
}