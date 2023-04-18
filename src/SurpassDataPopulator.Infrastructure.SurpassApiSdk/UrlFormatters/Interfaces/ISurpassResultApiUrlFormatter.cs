namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassResultApiUrlFormatter : ISurpassApiUrlFormatter
    {
        string GetForQueryString(string opt, bool markedExternally, bool includeExamsInMarking);

        string GetForResultIdItemId(int resultId, string itemId);

        string GetForResultKeycodeItemId(string keyCode, string itemId);

        string GetManyResultsForId(long id, string queryString = "", bool makerdExternally = false);

        string GetManyResultsForKeycode(string keycode, string queryString = "", bool makerdExternally = false);

        string GetForId(
            long id,
            bool showItemResponses = false,
            bool showAnalysis = false,
            bool returnDownloadData = false);

        string GetForKeycode(
            string keycode,
            bool showItemResponses = false,
            bool showAnalysis = false,
            bool returnDownloadData = false);

        string GetForCandidateInteraction(string keycode, bool includeDebugEvents);

        string GetForCandidateInteraction(int sessionId, bool includeDebugEvents);

        string GetForClientInformation(long sessionId);

        string GetForClientInformation(string keycode);

        string GetForStateChanges(long sessionId);

        string GetForStateChanges(string keycode);

        string GetForTbsTranslation(string keycode);
    }
}
