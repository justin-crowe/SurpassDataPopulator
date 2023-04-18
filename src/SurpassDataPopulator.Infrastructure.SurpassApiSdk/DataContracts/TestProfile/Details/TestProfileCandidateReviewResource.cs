using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details
{
    [DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
    public class TestProfileCandidateReviewResource
    {
        [DataMember(Name = ApiConsts.Members.CorrectItemsEnable, EmitDefaultValue = true)]
        public bool CorrectItemsEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.IncorrectItemsEnable, EmitDefaultValue = true)]
        public bool IncorrectItemsEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.UnattemptedItemsEnable, EmitDefaultValue = true)]
        public bool UnattemptedItemsEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateResponseEnable, EmitDefaultValue = true)]
        public bool CandidateResponseEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.CorrectAnswersEnable, EmitDefaultValue = true)]
        public bool CorrectAnswersEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateFeedbackEnable, EmitDefaultValue = true)]
        public bool CandidateFeedbackEnable { get; set; }
    }
}
