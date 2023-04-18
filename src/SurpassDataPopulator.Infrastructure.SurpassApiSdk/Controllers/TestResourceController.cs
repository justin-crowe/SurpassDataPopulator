using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Test;
using SurpassApiSdk.DataContracts.TestForm;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class TestResourceController : ITestResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassTestUrlFormatter _urlFormatter;

        internal TestResourceController(IRestApiClient restApiClient, ISurpassTestUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Create test resource in the database using provided data.
        /// </summary>
        /// <param name="testInput">Test details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Post(TestInputResource testInput)
        {
            return _restApiClient.CallPost<PostResponseModel, TestInputResource>(_urlFormatter.Get(), testInput);
        }

        /// <summary>
        /// Get test resources from the database using provided filters.
        /// </summary>
        /// <param name="queryString">the filter string </param>
        /// <returns>Response model containing a list of the Tests found using the criteria.</returns>
        public TimeZonePageResponse<TestLinkedResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestLinkedResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get test resources from the database using test id.
        /// </summary>
        /// <param name="id">Test id </param>
        /// <returns>Response model containing the Tests found using the id.</returns>
        public TimeZonePageResponse<TestDetailedResource> Get(long id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestDetailedResource>>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Get all testForms resources that match the query string.
        /// </summary>
        /// <param name="id">Test id</param>
        /// <param name="queryString">OData query string</param>
        /// <param name="scheduledTestFormsOnly">show scheduled test forms only</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all test forms resources relating to test form and matching the filter.If ScheduledTestFormsOnly used, only scheduled test forms are shown.
        /// </returns>
        public TimeZonePageResponse<TestFormLinkedResource> GetTestFormsByTestId(
            int id,
            string queryString = null,
            bool scheduledTestFormsOnly = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestFormLinkedResource>>(
                _urlFormatter.GetManyTestFormsForTestId(id, queryString, scheduledTestFormsOnly));
        }

        /// <summary>
        /// Get all testForms resources that match the query string.
        /// </summary>
        /// <param name="reference">Test reference</param>
        /// <param name="queryString">OData query string</param>
        /// <param name="scheduledTestFormsOnly">show scheduled test forms only</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all test forms resources relating to test form and matching the filter.If ScheduledTestFormsOnly used, only scheduled test forms are shown.
        /// </returns>
        public TimeZonePageResponse<TestFormLinkedResource> GetTestFormsByTestRef(
            string reference,
            string queryString = null,
            bool scheduledTestFormsOnly = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestFormLinkedResource>>(
                _urlFormatter.GetManyTestFormsForTestReference(reference, queryString, scheduledTestFormsOnly));
        }
    }
}
