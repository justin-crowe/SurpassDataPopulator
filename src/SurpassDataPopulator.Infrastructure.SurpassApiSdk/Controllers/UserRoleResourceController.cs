using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.UserPermission;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class UserRoleResourceController : IUserRoleResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal UserRoleResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all user permission resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string of string empty</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all user permission resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<UserRoleResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<UserRoleResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    /// <summary>
    /// Get single user permission resource that matches the id.
    /// </summary>
    /// <param name="id">User permission id</param>
    /// <returns>
    /// Response model that contains user permission details.
    /// </returns>
    public PageResponse<UserRoleDetailedResource> Get(long id)
    {
        return _restApiClient.CallGet<PageResponse<UserRoleDetailedResource>>(_urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Create user permission resource in the database using provided data.
    /// </summary>
    /// <param name="userRole">User permission details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Post(UserRoleCreateResource userRole)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, UserRoleCreateResource>(
            _urlFormatter.Get(),
            userRole);
    }

    /// <summary>
    /// Delete user permission resource from the database using provided data.
    /// </summary>
    /// <param name="id">User permission id</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Delete(long id)
    {
        return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForId(id));
    }
}