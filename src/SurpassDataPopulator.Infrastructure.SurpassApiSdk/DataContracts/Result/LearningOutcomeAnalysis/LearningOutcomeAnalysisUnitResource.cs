using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result.LearningOutcomeAnalysis
{
    [DataContract(Name = ApiConsts.Contracts.Unit, Namespace = "")]
    public class LearningOutcomeAnalysisUnitResource
    {
        [DataMember(Name = ApiConsts.Members.UnitName)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.AttemptCount)]
        public int AttemptCount { get; set; }

        [DataMember(Name = ApiConsts.Members.CorrectCount)]
        public int CorrectCount { get; set; }

        [DataMember(Name = ApiConsts.Members.TotalMark)]
        public decimal? TotalMark { get; set; }

        [DataMember(Name = ApiConsts.Members.UserMark)]
        public decimal? UserMark { get; set; }

        [DataMember(Name = ApiConsts.Members.LearningOutcomes)]
        public List<LearningOutcomeAnalysisResource> LearningOutcomes { get; set; }
    }
}
