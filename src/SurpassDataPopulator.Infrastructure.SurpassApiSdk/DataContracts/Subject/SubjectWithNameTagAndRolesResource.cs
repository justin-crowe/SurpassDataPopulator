using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Subject;

[DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
public class SubjectWithNameTagAndRolesResource : SubjectWithNameTagResource
{
    [DataMember(Name = ApiConsts.Members.Roles)]
    public IEnumerable<EditableRoleResource> Roles { get; set; }
}