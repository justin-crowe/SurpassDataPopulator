using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class PermissionResourceController : IPermissionResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal PermissionResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all permission resources.
        /// </summary>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all permission resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<RoleTypeResource> Get()
        {
            return _restApiClient.CallGet<TimeZonePageResponse<RoleTypeResource>>(_urlFormatter.Get());
        }
    }
}
