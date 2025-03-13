using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Permissions;

[DataContract(Name = ApiConsts.Contracts.UserPermission, Namespace = "")]
public class CentreSubjectRoleCreateResource
{
    [DataMember(Name = ApiConsts.Members.Centre, EmitDefaultValue = false, Order = 2)]
    public Resource Centre { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false, Order = 3)]
    public Resource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.Permission, EmitDefaultValue = false, Order = 4)]
    public RoleResource Role { get; set; }

    [DataMember(Name = ApiConsts.Members.IsSecureClient, EmitDefaultValue = false, Order = 5)]
    public bool IsSecureClient { get; set; }
}