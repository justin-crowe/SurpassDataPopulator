using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Namespace = "")]
public class RescoredQuestionItemResource : RescoredItemResource
{
    [DataMember(Name = ApiConsts.Members.AnswerOptions, Order = 10)]
    public List<RescoredAnswerOptionResource> AnswerOptions { get; set; }
}