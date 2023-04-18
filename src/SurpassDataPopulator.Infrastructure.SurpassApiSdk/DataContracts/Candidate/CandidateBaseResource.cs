using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate
{
    /// <summary>
    /// Represents a base candidate properties for creating and updating
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Candidate, Namespace = "")]
    public class CandidateBaseResource
    {
        /// <summary>
        /// Candidate first name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.FirstName)]
        public string FirstName { get; set; }

        /// <summary>
        /// Candidate middle name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.MiddleName)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Candidate last name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.LastName)]
        public string LastName { get; set; }

        /// <summary>
        /// Candidate date of birth
        /// </summary>
        [DataMember(Name = ApiConsts.Members.DateOfBirth)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Candidate gender
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Gender)]
        public string Gender { get; set; }

        /// <summary>
        /// Candidate email address
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Email)]
        public string Email { get; set; }

        /// <summary>
        /// Candidate phone number
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Tel)]
        public string Tel { get; set; }

        /// <summary>
        /// Candidate unique learner number
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Uln)]
        public string Uln { get; set; }

        /// <summary>
        /// Candidate special requirements
        /// </summary>
        [DataMember(Name = ApiConsts.Members.ReasonableAdjustments)]
        public bool? SpecialRequirements { get; set; }

        /// <summary>
        /// Candidate is external
        /// </summary>
        [DataMember(Name = ApiConsts.Members.IsExternal)]
        [DefaultValue(false)]
        public bool? IsExternal { get; set; }

        /// <summary>
        /// Candidate expiry date
        /// </summary>
        [DataMember(Name = ApiConsts.Members.ExpiryDate)]
        public DateTime? ExpiryDate { get; set; }
    }
}
