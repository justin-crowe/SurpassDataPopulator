using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.UserPermission;

[ControllerName(ApiConsts.Segments.UserPermission, 2)]
[DataContract(Name = ApiConsts.Contracts.UserPermission, Namespace = "")]
public class UserRoleBaseResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.Centre, EmitDefaultValue = false, Order = 4)]
    public CentreLinkedResource Centre { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false, Order = 5)]
    public SubjectLinkedResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.Permission, EmitDefaultValue = true, Order = 6)]
    public RoleResource Role { get; set; }
}