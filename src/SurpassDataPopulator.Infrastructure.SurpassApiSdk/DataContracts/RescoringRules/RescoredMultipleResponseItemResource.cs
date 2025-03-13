using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Namespace = "")]
public class RescoredMultipleResponseItemResource : RescoredQuestionMultipleResponseItemResource
{
    [DataMember(Name = ApiConsts.Members.OriginalItemMarkType, Order = 10)]
    public string OriginalItemMarkType { get; set; }

    [DataMember(Name = ApiConsts.Members.OriginalOnlyAwardIfAllCorrect, Order = 20)]
    public bool? OriginalOnlyAwardIfAllCorrect { get; set; }

    [DataMember(Name = ApiConsts.Members.NewOnlyAwardIfAllCorrect, Order = 30)]
    public bool? NewOnlyAwardIfAllCorrect { get; set; }

    [DataMember(Name = ApiConsts.Members.Combinations, Order = 60)]
    public List<RescoredCombinationResource> Combinations { get; set; }
}