using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Namespace = "")]
public class RescoredAnswerOptionResource
{
    [DataMember(Name = ApiConsts.Members.Label, Order = 10)]
    public string Label { get; set; }

    [DataMember(Name = ApiConsts.Members.DisplayLabel, Order = 20)]
    public string DisplayLabel { get; set; }

    [DataMember(Name = ApiConsts.Members.ContentType, Order = 30)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ContentTypeKey ContentType { get; set; }

    [DataMember(Name = ApiConsts.Members.OriginalMark, Order = 40)]
    public int? OriginalMark { get; set; }

    [DataMember(Name = ApiConsts.Members.NewMark, Order = 50)]
    public int? NewMark { get; set; }
}