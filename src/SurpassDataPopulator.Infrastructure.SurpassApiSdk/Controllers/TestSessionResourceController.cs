using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TestSession;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class TestSessionResourceController : ITestSessionResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassTestSessionApiUrlFormatter _urlFormatter;

        internal TestSessionResourceController(
            IRestApiClient restApiClient,
            ISurpassTestSessionApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        public TestSessionPostResponseModel Post(
            string keycode,
            List<TestSessionItemResponseResource> itemResponses,
            DateTime? completionDate = null)
        {
            return
                _restApiClient
                    .CallPost
                        <TestSessionPostResponseModel, List<TestSessionItemResponseResource>>(
                            _urlFormatter.GetForItemResponses(keycode, completionDate),
                            itemResponses);
        }

        /// <inheritdoc cref="ITestSessionResourceController.PostScannedItemResponses"/>
        public TestSessionPostResponseModel PostScannedItemResponses(
            string keycode,
            List<TestSessionScannedItemResponseResource> itemResponses,
            DateTime? completionDate = null,
            bool? markInSecureMarker = null)
        {
            return
                _restApiClient
                    .CallPost<TestSessionPostResponseModel, List<TestSessionScannedItemResponseResource>>(
                        _urlFormatter.GetForScannedItemResponses(keycode, completionDate, markInSecureMarker),
                        itemResponses);
        }

        public TimeZonePostResponseModel PostMarks(
            string keycode,
            DateTime completionDate,
            List<TestSessionMarkingInfo> itemMarks)
        {
            return
                _restApiClient
                    .CallPost
                        <TimeZonePostResponseModel, List<TestSessionMarkingInfo>>(
                            _urlFormatter.GetForItemMarks(keycode, completionDate),
                            itemMarks);
        }

        /// <summary>
        /// Update TestSession resource in the database using provided data.
        /// </summary>
        /// <param name="id">TestSession id</param>
        /// <param name="testSession">TestSession details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(int id, TestSessionStateUpdateResource testSession)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, TestSessionStateUpdateResource>(
                _urlFormatter.GetForId(id),
                testSession);
        }

        public TimeZonePostResponseModel PutByIdSubmitMarkedExam(int id)
        {
            return _restApiClient.CallPutWithEmptyBody<TimeZonePostResponseModel>(
                _urlFormatter.GetForSubmitMarkedExamById(id));
        }

        public TimeZonePostResponseModel PutByKeycodeSubmitMarkedExam(string keycode)
        {
            return _restApiClient.CallPutWithEmptyBody<TimeZonePostResponseModel>(
                _urlFormatter.GetForSubmitMarkedExamByKeycode(keycode));
        }

        public TimeZonePageResponse<TestSessionFileDetailedResource> GetTestSessionFile(int id, int fileId)
        {
            return _restApiClient
                .CallGet<TimeZonePageResponse<TestSessionFileDetailedResource>>(
                    _urlFormatter.GetForTestSessionFileById(id, fileId));
        }

        public TimeZonePageResponse<TestSessionFileDetailedResource> GetTestSessionFile(string keycode, int fileId)
        {
            return _restApiClient
                .CallGet<TimeZonePageResponse<TestSessionFileDetailedResource>>(
                    _urlFormatter.GetForTestSessionFileByKeycode(keycode, fileId));
        }

        /// <summary>
        /// Update TestSession resource in the database using provided data.
        /// </summary>
        /// <param name="keycode">TestSession KeyCode</param>
        /// <param name="testSession">TestSession details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TimeZonePostResponseModel Put(string keycode, TestSessionStateUpdateResource testSession)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, TestSessionStateUpdateResource>(
                _urlFormatter.GetForKeycode(keycode),
                testSession);
        }

        /// <summary>
        /// Get all TestSessions that match the query string
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total test sessions count, next and previous pages links, and etc.,
        /// and contains all test session resources that match the filter.
        /// </returns>
        /// <param name="showMarkingProgress">show marking progress</param>
        /// <param name="includeAdditionalInfo">include additional information</param>
        /// <param name="showTestForm">show test form</param>
        /// <param name="showTest">show test</param>
        public TimeZonePageResponse<TestSessionResource> Get(
            string queryString = null,
            bool showMarkingProgress = false,
            bool includeAdditionalInfo = false,
            bool showTestForm = false,
            bool showTest = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestSessionResource>>(
                _urlFormatter.GetForQueryString(
                    queryString,
                    showMarkingProgress,
                    includeAdditionalInfo,
                    showTestForm,
                    showTest));
        }

        /// <summary>
        /// Get all TestSessions that match the query string, the response includes additional data like candidate, centre, testSession state, downloaded to secureClient
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <param name="showMarkingProgress">show marking progress</param>
        /// <returns>
        /// Response model that contains common info like total test sessions count, next and previous pages links, and etc.,
        /// and contains all test session resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<TestSessionExtendedResource> GetWithAdditionalInfo(
            string queryString = null,
            bool showMarkingProgress = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestSessionExtendedResource>>(
                _urlFormatter.GetForQueryString(queryString, showMarkingProgress, true));
        }

        /// <summary>
        /// Get Test Session by ID
        /// </summary>
        /// <param name="id">TestSession Id</param>
        /// <param name="returnDownloadData">return information for downloading data</param>
        /// <param name="returnAdditionalInformation">return additional information</param>
        /// <returns>Returns TestSession for ID</returns>
        public TimeZonePageResponse<TestSessionDetailedResource> GetById(
            int id,
            bool returnDownloadData = false,
            bool returnAdditionalInformation = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestSessionDetailedResource>>(
                _urlFormatter.GetForId(id, returnDownloadData, returnAdditionalInformation));
        }

        /// <summary>
        /// Get Test Session by Keycode
        /// </summary>
        /// <param name="keycode">TestSession KeyCode</param>
        /// <param name="returnDownloadData">return information for downloading data</param>
        /// <param name="returnAdditionalInformation">return additional information</param>
        /// <returns>Returns TestSession for Keycode</returns>
        public TimeZonePageResponse<TestSessionDetailedResource> GetByKeycode(
            string keycode,
            bool returnDownloadData = false,
            bool returnAdditionalInformation = false)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TestSessionDetailedResource>>(
                _urlFormatter.GetForKeycode(keycode, returnDownloadData, returnAdditionalInformation));
        }

        /// <summary>
        /// Reset exam session state to "Scheduled But Not Created" (Code 1)
        /// </summary>
        /// <param name="keycode">Test session keycode to change state</param>
        /// <param name="currentTestFormRef">Current test form of test session</param>
        /// <param name="updatedTestFormRef">Test form to update</param>
        /// <returns></returns>
        public TimeZonePostResponseModel Patch(string keycode, string currentTestFormRef, string updatedTestFormRef)
        {
            return _restApiClient.CallPatch<TimeZonePostResponseModel>(
                _urlFormatter.GetForPatch(keycode, currentTestFormRef, updatedTestFormRef));
        }
    }
}
