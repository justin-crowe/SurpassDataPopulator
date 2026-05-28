using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Namespace = "")]
public class RescoredQuestionMultipleResponseItemResource : RescoredItemResource
{
    [DataMember(Name = ApiConsts.Members.AnswerOptions, Order = 10)]
    public List<RescoredAnswerOptionMultipleResponseItemResource> AnswerOptions { get; set; }
}