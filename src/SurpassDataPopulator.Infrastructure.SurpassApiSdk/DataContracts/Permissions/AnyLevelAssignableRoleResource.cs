using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Permissions;

[DataContract(Name = ApiConsts.Contracts.Permission, Namespace = "")]
public class AnyLevelAssignableRoleResource : RoleResource
{
    [DataMember(Name = ApiConsts.Members.CentreId, Order = 2, EmitDefaultValue = false)]
    public long? CentreId { get; set; }

    [DataMember(Name = ApiConsts.Members.SubjectId, Order = 3, EmitDefaultValue = false)]
    public long? SubjectId { get; set; }

    [DataMember(Name = ApiConsts.Members.IsSecureClient, Order = 4, EmitDefaultValue = false)]
    public bool IsSecureClient { get; set; }

    [DataMember(Name = ApiConsts.Members.RecordId, EmitDefaultValue = true)]
    public long RecordId { get; set; }
}