namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassTestSessionApiUrlFormatter : ISurpassApiUrlFormatter
{
    string GetForItemResponses(string keycode, DateTime? completionDate);

    string GetForScannedItemResponses(string keycode, DateTime? completionDate, bool? markInSecureMarker);

    string GetForItemMarks(string keycode, DateTime completionDate);

    string GetForQueryString(
        string queryString,
        bool showMarkingProgress = false,
        bool includeAdditionalInfo = false,
        bool showTestForm = false,
        bool showTest = false);

    string GetForSubmitMarkedExamById(int examId);

    string GetForSubmitMarkedExamByKeycode(string keycode);

    string GetForPatch(string keycode, string currentTestFormRef, string updatedTestFormRef);

    string GetForId(int id, bool returnDownloadData, bool returnAdditionalInformation = false);

    string GetForKeycode(string keycode, bool returnDownloadData, bool returnAdditionalInformation = false);

    string GetForTestSessionFileByKeycode(string keycode, int fileId);

    string GetForTestSessionFileById(int id, int fileId);
}