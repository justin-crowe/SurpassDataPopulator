using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate
{
    /// <summary>
    /// Represents a base candidate properties for creating and updating
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Candidate, Namespace = "")]
    public class CandidateExtendedResource : CandidateBaseResource
    {
        /// <summary>
        /// Candidate associated centres
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Centres)]
        public IEnumerable<CentreResource> Centres { get; set; }

        /// <summary>
        /// Candidate associated tests
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Subjects)]
        public IEnumerable<SubjectResource> Subjects { get; set; }

        [DataMember(Name = ApiConsts.Members.ExtendedDemographics)]
        public string ExtendedDemographics { get; set; }
    }
}
