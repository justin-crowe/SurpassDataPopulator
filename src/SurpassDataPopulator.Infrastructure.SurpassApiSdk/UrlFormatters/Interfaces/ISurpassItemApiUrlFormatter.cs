namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassItemApiUrlFormatter : ISurpassBasicPageApiUrlFormatter
    {
        string GetForQueryString(string queryString, bool includeDeleted);
    }
}
