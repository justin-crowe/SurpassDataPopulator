using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TestProfile;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class TestProfileResourceController : ITestProfileResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal TestProfileResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get single test profile resource that matches the id.
        /// </summary>
        /// <param name="id">Test Profile id</param>
        /// <returns>
        /// Response model that contains test profile details.
        /// </returns>
        public TimeZonePageResponse<TestProfileDetailedResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestProfileDetailedResource>>(
                _urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Create a test profile resource in the database using provided data.
        /// </summary>
        /// <param name="testProfileInput">TestProfile details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Post(TestProfileInputResource testProfileInput)
        {
            return _restApiClient.CallPost<PostResponseModel, TestProfileInputResource>(
                _urlFormatter.Get(),
                testProfileInput);
        }
    }
}
