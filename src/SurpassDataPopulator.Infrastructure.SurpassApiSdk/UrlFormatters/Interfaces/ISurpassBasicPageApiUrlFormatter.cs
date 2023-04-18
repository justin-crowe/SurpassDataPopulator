namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassBasicPageApiUrlFormatter : ISurpassApiUrlFormatter
    {
        string GetForIdAssistiveId(long id, long assistiveId);
    }
}
