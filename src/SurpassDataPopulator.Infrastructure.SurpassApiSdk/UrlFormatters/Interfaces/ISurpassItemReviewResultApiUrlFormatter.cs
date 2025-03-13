namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassItemReviewResultApiUrlFormatter : ISurpassApiUrlFormatter
{
    string GetForItemReviewResults(long taskId, string queryString = null);

    string GetForItemReviewResults(string taskReference, string queryString = null);

    string GetForItemReviewResult(long resultId);
}