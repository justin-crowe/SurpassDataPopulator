using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TestSession;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ITestSessionResourceController
{
    TestSessionPostResponseModel Post(
        string keycode,
        List<TestSessionItemResponseResource> itemResponses,
        DateTime? completionDate = null);

    /// <summary>
    /// Prepares and sends the POST request for the Scanned Item Responses.
    /// </summary>
    /// <param name="keycode">The exam session keycode.</param>
    /// <param name="scannedItemResponses">The list of scanned item responses.</param>
    /// <param name="completionDate">Exam session completion date (<c>null</c> if the parameter is not used).</param>
    /// <param name="markInSecureMarker">Contains <c>true</c> if the exam session should be marked in the Secure Marker (<c>null</c> if the parameter is not used).</param>
    /// <returns>The response model.</returns>
    TestSessionPostResponseModel PostScannedItemResponses(
        string keycode,
        List<TestSessionScannedItemResponseResource> scannedItemResponses,
        DateTime? completionDate = null,
        bool? markInSecureMarker = null);

    TimeZonePostResponseModel PostMarks(
        string keycode,
        DateTime completionDate,
        List<TestSessionMarkingInfo> itemResponses);

    TimeZonePostResponseModel Put(string keycode, TestSessionStateUpdateResource testSession);

    TimeZonePostResponseModel Put(int id, TestSessionStateUpdateResource testSession);

    TimeZonePageResponse<TestSessionResource> Get(
        string queryString = null,
        bool showMarkingProgress = false,
        bool includeAdditionalInfo = false,
        bool showTestForm = false,
        bool showTest = false);

    TimeZonePageResponse<TestSessionExtendedResource> GetWithAdditionalInfo(
        string queryString = null,
        bool showMarkingProgress = false);

    TimeZonePageResponse<TestSessionDetailedResource> GetByKeycode(
        string keycode,
        bool returnDownloadData = false,
        bool returnAdditionalInformation = false);

    TimeZonePageResponse<TestSessionDetailedResource> GetById(
        int id,
        bool returnDownloadData = false,
        bool returnAdditionalInformation = false);

    TimeZonePostResponseModel PutByIdSubmitMarkedExam(int id);

    TimeZonePostResponseModel PutByKeycodeSubmitMarkedExam(string keycode);

    TimeZonePostResponseModel Patch(string keycode, string currentTestFormRef, string updatedTestFormRef);

    TimeZonePageResponse<TestSessionFileDetailedResource> GetTestSessionFile(int id, int fileId);

    TimeZonePageResponse<TestSessionFileDetailedResource> GetTestSessionFile(string keycode, int fileId);
}