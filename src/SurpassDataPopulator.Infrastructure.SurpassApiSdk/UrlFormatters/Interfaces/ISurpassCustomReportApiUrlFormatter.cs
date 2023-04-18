namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassCustomReportApiUrlFormatter : ISurpassApiUrlFormatter
    {
        string GetForCheckReferenceUniqueness(string reference);

        string GetForFileGeneration();

        string GetForHtmlGeneration();

        string GetForWrappedHtmlGeneration();
    }
}
