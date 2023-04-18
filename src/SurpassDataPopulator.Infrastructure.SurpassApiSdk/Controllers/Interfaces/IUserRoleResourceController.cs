using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.UserPermission;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IUserRoleResourceController
    {
        TimeZonePostResponseModel Delete(long id);

        PageResponse<UserRoleDetailedResource> Get(long id);

        TimeZonePageResponse<UserRoleResource> Get(string queryString = null);

        TimeZonePostResponseModel Post(UserRoleCreateResource userRole);
    }
}
