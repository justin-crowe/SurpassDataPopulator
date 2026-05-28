using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Permissions;

[DataContract(Name = ApiConsts.Contracts.Permission, Namespace = "")]
public class RoleResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
    public int Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Assignable, Order = 1)]
    public bool Assignable { get; set; }
}