using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.County;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class CountyResourceController : ICountyResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal CountyResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all county resources that match the query string.
        /// </summary>
        /// <param name="queryString">Odata query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all counties resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<CountyLinkedResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<CountyLinkedResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single county resource that matches the id.
        /// </summary>
        /// <param name="id">County id</param>
        /// <returns>Response model that contains county details.</returns>
        public TimeZonePageResponse<CountyLinkedResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<CountyLinkedResource>>(_urlFormatter.GetForId(id));
        }
    }
}
