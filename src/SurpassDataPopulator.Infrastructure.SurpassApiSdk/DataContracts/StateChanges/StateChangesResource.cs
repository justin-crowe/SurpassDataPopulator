using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.StateChanges;

[DataContract(Name = ApiConsts.Contracts.StateChanges, Namespace = "")]
[ControllerName(ApiConsts.Segments.StateChanges, 2)]
public class StateChangesResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.StateChanges, EmitDefaultValue = true, Order = 4)]
    public List<StateChangeResource> StateChanges { get; set; }
}