using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.UserPermission
{
    [ControllerName(ApiConsts.Segments.UserPermission, 2)]
    [DataContract(Name = ApiConsts.Contracts.UserPermission, Namespace = "")]
    public class UserRoleDetailedResource : UserRoleBaseResource
    {
        [DataMember(Name = ApiConsts.Members.User, EmitDefaultValue = false, Order = 3)]
        public UserResource User { get; set; }
    }
}
