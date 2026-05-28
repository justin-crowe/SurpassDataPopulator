using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Section;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.Section, Namespace = "")]
public class SectionResource
{
    [DataMember(Name = ApiConsts.Members.Id)]
    public int Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Mark)]
    public double Mark { get; set; }

    [DataMember(Name = ApiConsts.Members.PercentageMark)]
    public double PercentageMark { get; set; }

    [DataMember(Name = ApiConsts.Members.AvailableMarks)]
    public int AvailableMarks { get; set; }

    [DataMember(Name = ApiConsts.Members.Pass)]
    public bool Pass { get; set; }

    [DataMember(Name = ApiConsts.Members.PassMark)]
    public double? PassMark { get; set; }

    [DataMember(Name = ApiConsts.Members.PassPercentage)]
    public double? PassPercentage { get; set; }

    [DataMember(Name = ApiConsts.Members.PassIrt)]
    public double? PassIrt { get; set; }

    [DataMember(Name = ApiConsts.Members.PassMarkType)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ResultMarkTypeKey PassMarkType { get; set; }

    [DataMember(Name = ApiConsts.Members.IrtTheta)]
    public double? IrtTheta { get; set; }

    [DataMember(Name = ApiConsts.Members.ViewingTime)]
    public int ViewingTime { get; set; }

    [DataMember(Name = ApiConsts.Members.Items)]
    public IEnumerable<ItemResource> Items { get; set; }

    [DataMember(Name = ApiConsts.Members.SectionSelectorId)]
    public int? SectionSelectorId { get; set; }

    [DataMember(Name = ApiConsts.Members.Selected)]
    public bool? Selected { get; set; }

    [DataMember(Name = ApiConsts.Members.SectionStartTime)]
    public DateTime? StartTime { get; set; }

    [DataMember(Name = ApiConsts.Members.SectionEndTime)]
    public DateTime? EndTime { get; set; }

    [DataMember(Name = ApiConsts.Members.IsPoolTimeSection)]
    public bool? IsPoolTimeSection { get; set; }

    [DataMember(Name = ApiConsts.Members.PoolName)]
    public string PoolName { get; set; }

    [DataMember(Name = ApiConsts.Members.IsSurveySection)]
    public bool IsSurveySection { get; set; }

    [DataMember(Name = ApiConsts.Members.DecisionPoint)]
    public ResultDecisionPointResource DecisionPoint { get; set; }
}