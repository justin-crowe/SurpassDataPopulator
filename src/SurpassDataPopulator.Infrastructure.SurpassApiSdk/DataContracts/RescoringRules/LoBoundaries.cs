using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.RescoringRules;

[DataContract(Name = ApiConsts.Members.LoBoundaries, Namespace = "")]
public class LoBoundaries
{
    [DataMember(Name = ApiConsts.Members.LearningOutcomeBoundariesApplied)]
    public bool LearningOutcomeBoundariesApplied { get; set; }

    [DataMember(Name = ApiConsts.Members.LearningOutcomeBoundaries)]
    public List<LearningOutcomeBoundaryResource> LearningOutcomeBoundaries { get; set; }
}