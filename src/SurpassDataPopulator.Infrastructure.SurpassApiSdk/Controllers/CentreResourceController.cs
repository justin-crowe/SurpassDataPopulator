using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class CentreResourceController : ICentreResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal CentreResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all centre resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all centre resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<CentreLinkedResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<CentreLinkedResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single centre resource that matches the id.
        /// </summary>
        /// <param name="id">Centre id</param>
        /// <returns>
        /// Response model that contains centre details.
        /// </returns>
        public TimeZonePageResponse<CentreDetailedResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<CentreDetailedResource>>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Get single centre resource that matches the reference.
        /// </summary>
        /// <param name="reference">Centre reference</param>
        /// <returns>
        /// Response model that contains centre details.
        /// </returns>
        public TimeZonePageResponse<CentreDetailedResource> GetByReference(string reference)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<CentreDetailedResource>>(
                _urlFormatter.GetForReference(reference));
        }

        /// <summary>
        /// Create centre resource in the database.
        /// </summary>
        /// <param name="centreResource">Centre details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Post(CentreCreateResource centreResource)
        {
            return _restApiClient.CallPost<TimeZonePostResponseModel, CentreCreateResource>(
                _urlFormatter.Get(),
                centreResource);
        }

        /// <summary>
        /// Update centre resource in the database using provided data.
        /// </summary>
        /// <param name="id">Centre id</param>
        /// <param name="centreResource">Centre details</param>
        /// <param name="headers">Request headers</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(
            int id,
            CentreUpdateResource centreResource,
            IEnumerable<HttpHeader> headers = null)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, CentreUpdateResource>(
                _urlFormatter.GetForId(id),
                centreResource,
                headers);
        }

        /// <summary>
        /// Update centre resource in the database using provided data.
        /// </summary>
        /// <param name="reference">Centre reference</param>
        /// <param name="centreResource">Centre details</param>
        /// <param name="headers">Request headers</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(
            string reference,
            CentreUpdateResource centreResource,
            IEnumerable<HttpHeader> headers = null)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, CentreUpdateResource>(
                _urlFormatter.GetForReference(reference),
                centreResource,
                headers);
        }

        /// <summary>
        /// Delete centre resource from the database using provided data.
        /// </summary>
        /// <param name="id">Centre id</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Delete(int id)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Delete centre resource from the database using provided data.
        /// </summary>
        /// <param name="reference">Centre reference</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Delete(string reference)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForReference(reference));
        }
    }
}
