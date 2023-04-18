using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate
{
    /// <summary>
    /// Represents a base candidate properties
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Candidate, Namespace = "")]
    public class CandidateDetailedResource : CandidateResource
    {
        /// <summary>
        /// Candidate first name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.FirstName, Order = 3)]
        public string FirstName { get; set; }

        /// <summary>
        /// Candidate middle name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.MiddleName, Order = 4)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Candidate last name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.LastName, Order = 5)]
        public string LastName { get; set; }

        /// <summary>
        /// Candidate date of birth
        /// </summary>
        [DataMember(Name = ApiConsts.Members.DateOfBirth, Order = 6)]
        [Unsortable]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Candidate gender
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Gender, Order = 7)]
        public string Gender { get; set; }

        /// <summary>
        /// Candidate email address
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Email, Order = 8)]
        [Unsortable]
        public string Email { get; set; }

        /// <summary>
        /// Candidate phone number
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Tel, Order = 9)]
        [Unsortable]
        public string Tel { get; set; }

        /// <summary>
        /// Candidate unique learner number
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Uln, Order = 10)]
        [Unsortable]
        public string Uln { get; set; }

        /// <summary>
        /// Candidate date of birth
        /// </summary>
        [DataMember(Name = ApiConsts.Members.ReasonableAdjustments, Order = 11)]
        [Unsortable]
        public bool SpecialRequirements { get; set; }

        /// <summary>
        /// Candidate is retired
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Retired, Order = 12)]
        [Unsortable]
        public bool Retired { get; set; }

        /// <summary>
        /// Candidate expiry date
        /// </summary>
        [DataMember(Name = ApiConsts.Members.ExpiryDate, Order = 13)]
        [Unsortable]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Candidate is external
        /// </summary>
        [DataMember(Name = ApiConsts.Members.IsExternal, Order = 14)]
        [Unsortable]
        public bool IsExternal { get; set; }

        /// <summary>
        /// Candidate associated centres
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Centres, Order = 15)]
        [Unsortable]
        public IEnumerable<CentreLinkedResource> Centres { get; set; }

        /// <summary>
        /// Candidate associated tests
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Subjects, Order = 16)]
        [Unsortable]
        public IEnumerable<SubjectLinkedResource> Subjects { get; set; }

        /// <summary>
        /// Candidate tag groups
        /// </summary>
        [DataMember(Name = ApiConsts.Members.TagGroups, Order = 17)]
        [Unsortable]
        public IEnumerable<CandidateTagGroupResource> TagGroups { get; set; }

        /// <summary>
        /// Candidate Extended Demographics
        /// </summary>
        [DataMember(Name = ApiConsts.Members.ExtendedDemographics, Order = 18)]
        [Unsortable]
        public string ExtendedDemographics { get; set; }
    }
}
