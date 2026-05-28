using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Permissions;

[DataContract(Name = ApiConsts.Contracts.Permission, Namespace = "")]
public class ChangedAssignableRoleResource : AnyLevelAssignableRoleResource
{
    [DataMember(Name = ApiConsts.Members.Removed, Order = 5, EmitDefaultValue = false)]
    public bool Removed { get; set; }
}