using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Centre;

[DataContract(Name = ApiConsts.Contracts.Centre, Namespace = "")]
public class CentreWithDisableableRolesResource : CentreWithNameResource
{
    [DataMember(Name = ApiConsts.Members.Roles, EmitDefaultValue = false, Order = 4)]
    public IEnumerable<EditableRoleResource> Roles { get; set; }
}