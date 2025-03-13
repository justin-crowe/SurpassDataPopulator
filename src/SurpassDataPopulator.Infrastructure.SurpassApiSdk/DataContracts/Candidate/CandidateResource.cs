using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Candidate;

[ControllerName(ApiConsts.Segments.Candidate, 2)]
[DataContract(Name = ApiConsts.Contracts.Candidate, Namespace = "")]
public class CandidateResource : LinkedResource
{
}