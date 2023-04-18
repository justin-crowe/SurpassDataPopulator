using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestProfile.Details
{
    [DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
    public class TestProfileCandidateDetailsResource
    {
        [DataMember(Name = ApiConsts.Members.SelectAll, EmitDefaultValue = true)]
        public bool? SelectAll { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateFirstNameEnable, EmitDefaultValue = true)]
        public bool? CandidateFirstNameEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateLastNameEnable, EmitDefaultValue = true)]
        public bool? CandidateLastNameEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateDateOfBirthEnable, EmitDefaultValue = true)]
        public bool? CandidateDateOfBirthEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateGenderEnable, EmitDefaultValue = true)]
        public bool? CandidateGenderEnable { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateReferenceEnable, EmitDefaultValue = true)]
        public bool? CandidateReferenceEnable { get; set; }
    }
}
