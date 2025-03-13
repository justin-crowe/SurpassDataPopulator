using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.StateChanges;

[DataContract(Name = ApiConsts.Contracts.Column, Namespace = "")]
public class ColumnResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true, Order = 571)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.OldValue, EmitDefaultValue = true, Order = 572)]
    public string OldValue { get; set; }

    [DataMember(Name = ApiConsts.Members.NewValue, EmitDefaultValue = true, Order = 573)]
    public string NewValue { get; set; }
}