using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassItemReviewResultApiUrlFormatter : SurpassApiUrlFormatter,
        ISurpassItemReviewResultApiUrlFormatter
    {
        internal SurpassItemReviewResultApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForItemReviewResults(long taskId, string queryString = null)
        {
            var queryStr = $"taskId={taskId}";

            if (!string.IsNullOrEmpty(queryString))
                queryStr = string.Join("&", queryStr, queryString);

            return GetForQueryString(queryStr);
        }

        public string GetForItemReviewResults(string taskReference, string queryString = null)
        {
            var queryStr = $"taskReference={taskReference}";

            if (!string.IsNullOrEmpty(queryString))
                queryStr = string.Join("&", queryStr, queryString);

            return GetForQueryString(queryStr);
        }

        public string GetForItemReviewResult(long resultId)
        {
            return $"{Template}/{resultId}";
        }
    }
}
