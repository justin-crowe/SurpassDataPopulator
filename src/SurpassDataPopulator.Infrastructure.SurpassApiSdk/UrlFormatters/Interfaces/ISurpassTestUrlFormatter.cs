namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassTestUrlFormatter : ISurpassApiUrlFormatter
    {
        string GetManyTestFormsForTestId(long id, string queryString = null, bool scheduledTestFormsOnly = false);

        string GetManyTestFormsForTestReference(
            string reference,
            string queryString = null,
            bool scheduledTestFormsOnly = false);
    }
}
