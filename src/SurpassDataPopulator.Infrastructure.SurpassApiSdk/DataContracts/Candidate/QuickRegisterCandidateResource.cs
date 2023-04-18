using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate
{
    /// <summary>
    /// Represents a base candidate properties for creating and updating
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Candidate, Namespace = "")]
    public class QuickRegisterCandidateResource : CandidateBaseResource
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public int? Id { get; set; }

        /// <summary>
        /// Resource Reference
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Reference, Order = 1)]
        public string Reference { get; set; }
    }
}
