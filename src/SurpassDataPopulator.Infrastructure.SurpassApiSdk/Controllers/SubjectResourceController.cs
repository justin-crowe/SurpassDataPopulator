using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class SubjectResourceController : ISubjectResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal SubjectResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all subject resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all subject resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<SubjectLinkedResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<SubjectLinkedResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single subject resource that matches the id.
        /// </summary>
        /// <param name="id">Subject id</param>
        /// <returns>
        /// Response model that contains subject details.
        /// </returns>
        public TimeZonePageResponse<SubjectDetailedResource> Get(long id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<SubjectDetailedResource>>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Get single subject resource that matches the reference.
        /// </summary>
        /// <param name="reference">Subject reference</param>
        /// <returns>
        /// Response model that contains subject details.
        /// </returns>
        public TimeZonePageResponse<SubjectDetailedResource> GetByReference(string reference)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<SubjectDetailedResource>>(
                _urlFormatter.GetForReference(reference));
        }

        /// <summary>
        /// Create subject resource in the database.
        /// </summary>
        /// <param name="subjectResource">Subject details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Post(SubjectCreateResource subjectResource)
        {
            return _restApiClient.CallPost<TimeZonePostResponseModel, SubjectCreateResource>(
                _urlFormatter.Get(),
                subjectResource);
        }

        /// <summary>
        /// Update subject resource in the database using provided data.
        /// </summary>
        /// <param name="id">Subject id</param>
        /// <param name="subjectResource">Subject details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(
            long id,
            SubjectUpdateResource subjectResource,
            IEnumerable<HttpHeader> headers = null)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, SubjectUpdateResource>(
                _urlFormatter.GetForId(id),
                subjectResource,
                headers);
        }

        /// <summary>
        /// Update subject resource in the database using provided data.
        /// </summary>
        /// <param name="reference">Subject reference</param>
        /// <param name="subjectResource">Subject details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(
            string reference,
            SubjectUpdateResource subjectResource,
            IEnumerable<HttpHeader> headers = null)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, SubjectUpdateResource>(
                _urlFormatter.GetForReference(reference),
                subjectResource,
                headers);
        }

        /// <summary>
        /// Delete subject resource from the database using provided data.
        /// </summary>
        /// <param name="id">Subject id</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Delete(long id)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Delete subject resource from the database using provided data.
        /// </summary>
        /// <param name="reference">Subject reference</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Delete(string reference)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForReference(reference));
        }
    }
}
