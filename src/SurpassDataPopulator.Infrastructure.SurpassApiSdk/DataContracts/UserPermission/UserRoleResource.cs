using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.UserPermission
{
    [ControllerName(ApiConsts.Segments.UserPermission, 2)]
    [DataContract(Name = ApiConsts.Contracts.UserPermission, Namespace = "")]
    public class UserRoleResource : LinkedIdResource
    {
    }
}
