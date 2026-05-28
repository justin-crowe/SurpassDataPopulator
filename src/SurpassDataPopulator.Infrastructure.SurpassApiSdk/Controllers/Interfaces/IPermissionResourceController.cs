using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IPermissionResourceController
{
    TimeZonePageResponse<RoleTypeResource> Get();
}