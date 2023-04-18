using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate
{
    /// <summary>
    /// Represents a base candidate properties for creating candidate
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Candidate, Namespace = "")]
    public class CandidateCreateResource : CandidateExtendedResource
    {
        /// <summary>
        /// Resource Reference
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Reference, Order = 1, EmitDefaultValue = false)]
        public string Reference { get; set; }
    }
}
