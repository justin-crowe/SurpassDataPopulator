using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassResultApiUrlFormatter : SurpassApiUrlFormatter, ISurpassResultApiUrlFormatter
    {
        private const string ShowItemResponsesParam = "showItemResponses=true";
        private const string IncludeExamsInMarkingParam = "includeExamsInMarking=true";
        private const string IncludeMarkedExternallyParam = "markedExternally=true";
        private const string ShowAnalysisParam = "showAnalysis=true";
        private const string IncludeDebugEvents = "includeDebugEvents=true";
        private const string ReturnDownloadData = "returnDownloadData=true";

        public SurpassResultApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForQueryString(string queryString, bool markedExternally, bool includeExamsInMarking)
        {
            return GetForQueryStringPrivate(true, queryString, markedExternally, includeExamsInMarking);
        }

        public string GetForResultIdItemId(int resultId, string itemId)
        {
            return $"{GetManyResultsForId(resultId)}{itemId}";
        }

        public string GetForResultKeycodeItemId(string keyCode, string itemId)
        {
            return $"{GetManyResultsForKeycode(keyCode)}{itemId}";
        }

        public string GetManyResultsForId(long id, string queryString = "", bool markedExternally = false)
        {
            return
                $"{GetForId(id)}/ItemResponse/{GetForQueryStringWithMarkedExternally(queryString, markedExternally)}";
        }

        public string GetManyResultsForKeycode(string keycode, string queryString = "", bool markedExternally = false)
        {
            return
                $"{GetForKeycode(keycode)}/ItemResponse/{GetForQueryStringWithMarkedExternally(queryString, markedExternally)}";
        }

        public string GetForId(
            long id,
            bool showItemResponses = false,
            bool showAnalysis = false,
            bool returnDownloadData = false)
        {
            var finalParam = ComposeParamsForSingleGet(showItemResponses, showAnalysis, returnDownloadData);
            var url = $"{base.GetForId(id)}{finalParam}";
            return url;
        }

        public string GetForKeycode(
            string keycode,
            bool showItemResponses = false,
            bool showAnalysis = false,
            bool returnDownloadData = false)
        {
            var finalParam = ComposeParamsForSingleGet(showItemResponses, showAnalysis, returnDownloadData);
            var url = $"{base.GetForKeycode(keycode)}{finalParam}";
            return url;
        }

        public string GetForClientInformation(long sessionId)
        {
            return $"{this.GetForId(sessionId)}/ClientInformation";
        }

        public string GetForClientInformation(string keycode)
        {
            return $"{this.GetForKeycode(keycode)}/ClientInformation";
        }

        public string GetForStateChanges(long sessionId)
        {
            return $"{this.GetForId(sessionId)}/StateChanges";
        }

        public string GetForStateChanges(string keycode)
        {
            return $"{this.GetForKeycode(keycode)}/StateChanges";
        }

        public string GetForCandidateInteraction(string keycode, bool includeDebugEvents)
        {
            return $"{base.GetForKeycode(keycode)}/CandidateInteractions{(includeDebugEvents ? "?" + IncludeDebugEvents : string.Empty)}";
        }

        public string GetForCandidateInteraction(int sessionId, bool includeDebugEvents)
        {
            return
                $"{base.GetForId(sessionId)}/CandidateInteractions{(includeDebugEvents ? "?" + IncludeDebugEvents : string.Empty)}";
        }

        public string GetForTbsTranslation(string keycode)
        {
            return $"{base.GetForKeycode(keycode)}/TbsTranslation";
        }

        private string GetForQueryStringWithMarkedExternally(string queryString, bool markedExternally = false)
        {
            queryString = string.IsNullOrEmpty(queryString) ? string.Empty : "?" + queryString;
            return markedExternally ? $"?markedExternally=true&{queryString}" : queryString;
        }

        private string GetForQueryStringPrivate(
            bool includeTemplate,
            string queryString,
            bool markedExternally,
            bool includeExamsInMarking)
        {
            var url = queryString;
            if (markedExternally)
                url = IncludeMarkedExternallyParam + $"&{url}";
            if (includeExamsInMarking)
                url = IncludeExamsInMarkingParam + $"&{url}";

            if (includeTemplate)
                url = GetForQueryString(url);

            url = url ?? string.Empty;

            return url;
        }

        private string ComposeParamsForSingleGet(
            bool showItemResponses = false,
            bool showAnalysis = false,
            bool returnDownloadData = false)
        {
            var paramsArray = new List<string>()
            {
                showItemResponses ? ShowItemResponsesParam : null,
                showAnalysis ? ShowAnalysisParam : null,
                returnDownloadData ? ReturnDownloadData : null
            }.Where(i => i != null);

            return paramsArray.Any()
                ? ("?" + string.Join("&", paramsArray))
                : string.Empty;
        }
    }
}
