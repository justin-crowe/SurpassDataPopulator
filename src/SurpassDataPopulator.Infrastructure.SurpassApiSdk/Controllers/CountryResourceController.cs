using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Country;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class CountryResourceController : ICountryResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal CountryResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all country resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all countries resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<CountryLinkedResource> Get(string queryString = null)
        {
            return
                _restApiClient.CallGet<TimeZonePageResponse<CountryLinkedResource>>(
                    _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single country resource that matches the id.
        /// </summary>
        /// <param name="id">Country id</param>
        /// <returns>Response model that contains country details.</returns>
        public TimeZonePageResponse<CountryDetailedResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<CountryDetailedResource>>(_urlFormatter.GetForId(id));
        }
    }
}
