using System.Globalization;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters;

internal class SurpassTestSessionApiUrlFormatter : SurpassApiUrlFormatter, ISurpassTestSessionApiUrlFormatter
{
    private const string SubmitMarkedExam = "SubmitMarkedExam";
    private const string File = "File";
    private const string IncludeShowMarkingProgressParam = "showMarkingProgress=true";
    private const string IncludeAdditionalInfo = "includeAdditionalInfo=true";
    private const string СurrentTestFormRefParameter = "currentTestFormRef";
    private const string UpdatedTestFormRefParameter = "updatedTestFormRef";
    private const string ReturnDownloadData = "returnDownloadData=true";
    private const string ReturnAdditionalInformation = "returnAdditionalInformation=true";
    private const string MarkInSecureMarker = "markInSecureMarker={0}";
    private const string CompletionDate = "completionDate={0}";

    private const string ShowTestFormParam = "showTestForm=true";
    private const string ShowTestParam = "showTest=true";

    public SurpassTestSessionApiUrlFormatter(string template)
        : base(template)
    {
    }

    public string GetForItemResponses(string keycode, DateTime? completionDate) =>
        completionDate.HasValue
            ? $"{GetForKeycode(keycode)}/ItemResponses?completionDate={completionDate.Value:yyyy-MM-ddTHH:mm:ss}"
            : $"{GetForKeycode(keycode)}/ItemResponses";

    public string GetForScannedItemResponses(string keycode, DateTime? completionDate, bool? markInSecureMarker)
        =>
            $"{GetForKeycode(keycode)}/ScannedItemResponses/{ComposeParamsForScannedItemResponses(completionDate, markInSecureMarker)}";

    public string GetForItemMarks(string keycode, DateTime completionDate) =>
        $"{GetForKeycode(keycode)}/ItemMarks/?completionDate={completionDate:s}";

    public string GetForSubmitMarkedExamById(int examId)
    {
        return $"{GetForId(examId)}/{SubmitMarkedExam}";
    }

    public string GetForSubmitMarkedExamByKeycode(string keycode)
    {
        return $"{GetForKeycode(keycode)}/{SubmitMarkedExam}";
    }

    public string GetForTestSessionFileByKeycode(string keycode, int fileId)
    {
        return $"{GetForKeycode(keycode)}/{File}/{fileId}";
    }

    public string GetForTestSessionFileById(int id, int fileId)
    {
        return $"{GetForId(id)}/{File}/{fileId}";
    }

    public string GetForQueryString(
        string queryString,
        bool showMarkingProgress = false,
        bool includeAdditionalInfo = false,
        bool showTestForm = false,
        bool showTest = false)
    {
        var urlParams = new List<string>()
            {
                queryString,
                showMarkingProgress ? IncludeShowMarkingProgressParam : null,
                includeAdditionalInfo ? IncludeAdditionalInfo : null,
                showTestForm ? ShowTestFormParam : null,
                showTest ? ShowTestParam : null,
            }
            .Where(i => !string.IsNullOrEmpty(i))
            .ToArray();

        var url = string.Join("&", urlParams);
        var result = string.IsNullOrEmpty(url) ? Template : base.GetForQueryString(url);
        return result;
    }

    public string GetForPatch(string keycode, string currentTestFormRef, string updatedTestFormRef)
    {
        var url = $"{GetForKeycode(keycode)}?{СurrentTestFormRefParameter}={currentTestFormRef}&{UpdatedTestFormRefParameter}={updatedTestFormRef}";

        return url;
    }

    public string GetForId(int id, bool returnDownloadData, bool returnAdditionalInformation = false)
    {
        var finalParam = ComposeParamsForSingleGet(returnDownloadData, returnAdditionalInformation);
        var url = $"{GetForId(id)}{finalParam}";
        return url;
    }

    public string GetForKeycode(string keycode, bool returnDownloadData, bool returnAdditionalInformation = false)
    {
        var finalParam = ComposeParamsForSingleGet(returnDownloadData, returnAdditionalInformation);
        var url = $"{GetForKeycode(keycode)}{finalParam}";
        return url;
    }

    private string ComposeParamsForSingleGet(
        bool returnDownloadData = false,
        bool returnAdditionalInformation = false)
    {
        var paramsArray = new List<string>()
        {
            returnDownloadData ? ReturnDownloadData : null,
            returnAdditionalInformation ? ReturnAdditionalInformation : null
        }.Where(i => i != null);

        return paramsArray.Any()
            ? ("?" + string.Join("&", paramsArray))
            : string.Empty;
    }

    private string ComposeParamsForScannedItemResponses(DateTime? completionDate, bool? markInSecureMarker)
    {
        var paramsArray = new List<string>();

        if (markInSecureMarker.HasValue)
        {
            paramsArray.Add(string.Format(
                CultureInfo.InvariantCulture,
                MarkInSecureMarker,
                markInSecureMarker.Value ? "true" : "false"));
        }

        if (completionDate.HasValue)
        {
            paramsArray.Add(string.Format(
                CultureInfo.InvariantCulture,
                CompletionDate,
                completionDate.Value.ToString("yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture)));
        }

        return paramsArray.Count > 0
            ? "?" + string.Join("&", paramsArray)
            : string.Empty;
    }
}