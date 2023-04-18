using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class UserResourceController : IUserResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassUserApiUrlFormatter _urlFormatter;

        internal UserResourceController(IRestApiClient restApiClient, ISurpassUserApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all user resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all user resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<UserResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<UserResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single user resource that matches the id.
        /// </summary>
        /// <param name="id">User id</param>
        /// <param name="showPermissions"></param>
        /// <returns>
        /// Response model that contains user details.
        /// </returns>
        public TimeZonePageResponse<UserDetailedResource> Get(long id, bool showPermissions = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<UserDetailedResource>>(
                _urlFormatter.GetForId(id, showPermissions));
        }

        /// <summary>
        /// Get single user resource that matches the reference.
        /// </summary>
        /// <param name="reference">User reference</param>
        /// <param name="showPermissions"></param>
        /// <returns>
        /// Response model that contains user details.
        /// </returns>
        public TimeZonePageResponse<UserDetailedResource> GetByReference(string reference, bool showPermissions = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<UserDetailedResource>>(
                _urlFormatter.GetForReference(reference, showPermissions));
        }

        /// <summary>
        /// Create user resource in the database.
        /// </summary>
        /// <param name="user">User details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Post(UserCreateResource user)
        {
            return _restApiClient.CallPost<TimeZonePostResponseModel, UserCreateResource>(_urlFormatter.Get(), user);
        }

        /// <summary>
        /// Update user resource in the database using provided data.
        /// </summary>
        /// <param name="id">User id</param>
        /// <param name="user">User details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(long id, UserUpdateResource user, IEnumerable<HttpHeader> headers = null)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, UserUpdateResource>(
                _urlFormatter.GetForId(id),
                user,
                headers);
        }

        /// <summary>
        /// Update user resource in the database using provided data.
        /// </summary>
        /// <param name="reference">User name</param>
        /// <param name="user">User details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(
            string reference,
            UserUpdateResource user,
            IEnumerable<HttpHeader> headers = null)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, UserUpdateResource>(
                _urlFormatter.GetForReference(reference),
                user,
                headers);
        }

        /// <summary>
        /// Delete user resource from the database using provided data.
        /// </summary>
        /// <param name="id">User id</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Delete(int id)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Delete user resource from the database using provided data.
        /// </summary>
        /// <param name="reference">User id</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Delete(string reference)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForReference(reference));
        }
    }
}
