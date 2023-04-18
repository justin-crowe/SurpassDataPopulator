using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.UserPermission
{
    [DataContract(Name = ApiConsts.Contracts.UserPermission, Namespace = "")]
    public class UserRoleCreateResource : CentreSubjectRoleCreateResource
    {
        [DataMember(Name = ApiConsts.Members.User, EmitDefaultValue = false, Order = 1)]
        public Resource User { get; set; }
    }
}
