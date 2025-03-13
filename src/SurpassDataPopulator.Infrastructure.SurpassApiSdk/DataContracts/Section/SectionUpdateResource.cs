using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Section;

[DataContract(Name = ApiConsts.Contracts.Section, Namespace = "")]
public class SectionUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 1)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.DecisionPoint, EmitDefaultValue = true, Order = 2)]
    public DecisionPointResource DecisionPoint { get; set; }


    [DataMember(Name = ApiConsts.Members.AdditionalMediaReplays, EmitDefaultValue = true, Order = 3)]
    public AdditionalMediaReplayResource AdditionalMediaReplays { get; set; }
}