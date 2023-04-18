using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result.LearningOutcomeAnalysis
{
    [DataContract(Name = ApiConsts.Contracts.LearningOutcome, Namespace = "")]
    public class LearningOutcomeAnalysisResource
    {
        [DataMember(Name = ApiConsts.Members.LearnongOutcomeName)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.AttemptCount)]
        public int AttemptCount { get; set; }

        [DataMember(Name = ApiConsts.Members.CorrectCount)]
        public int CorrectCount { get; set; }

        [DataMember(Name = ApiConsts.Members.TotalMark)]
        public decimal? TotalMark { get; set; }

        [DataMember(Name = ApiConsts.Members.UserMark)]
        public decimal? UserMark { get; set; }

        [DataMember(Name = ApiConsts.Members.Score)]
        public string Score { get; set; }
    }
}
