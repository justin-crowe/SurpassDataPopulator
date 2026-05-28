using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.CandidateInteraction;

[DataContract(Name = ApiConsts.Contracts.CandidateInteraction, Namespace = "")]
[ControllerName(ApiConsts.Segments.CandidateInteractions, 2)]
public class CandidateInteractionResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.Interactions, EmitDefaultValue = true, Order = 4)]
    public IEnumerable<InteractionResource> Interactions { get; set; }
}