using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Namespace = "")]
public class RescoredCombinationResource
{
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Mark)]
    public int? Mark { get; set; }

    [DataMember(Name = ApiConsts.Members.AnswerOptions)]
    public List<RescoredAnswerOptionMultipleResponseItemResource> AnswerOptions { get; set; }
}