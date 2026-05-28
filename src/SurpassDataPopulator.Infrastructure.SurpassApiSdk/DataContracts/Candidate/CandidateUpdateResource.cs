using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Candidate;

/// <summary>
/// Represents a base candidate properties for updating candidate
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Candidate, Namespace = "")]
public class CandidateUpdateResource : CandidateExtendedResource
{
    /// <summary>
    /// Candidate is retired
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Retired)]
    public bool? Retired { get; set; }
}