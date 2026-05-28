using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Centre;

[DataContract(Name = ApiConsts.Contracts.Centre, Namespace = "")]
public class CentreWithRolesResource : CentreWithNameResource
{
    [DataMember(Name = ApiConsts.Members.Roles, EmitDefaultValue = false, Order = 4)]
    public IEnumerable<AnyLevelAssignableRoleResource> Roles { get; set; }
}