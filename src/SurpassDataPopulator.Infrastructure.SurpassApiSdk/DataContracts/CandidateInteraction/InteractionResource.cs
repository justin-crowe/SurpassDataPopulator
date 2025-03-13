using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CandidateInteraction;

[DataContract(Name = ApiConsts.Contracts.Interaction, Namespace = "")]
public class InteractionResource
{
    [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true)]
    public string Type { get; set; }

    [DataMember(Name = ApiConsts.Members.Data, EmitDefaultValue = true)]
    public string Data { get; set; }

    [DataMember(Name = ApiConsts.Members.Time, EmitDefaultValue = true)]
    public DateTime? Time { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemId, EmitDefaultValue = true)]
    public string ItemId { get; set; }
}