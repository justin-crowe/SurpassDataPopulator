namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassTaskApiUrlFormatter : ISurpassApiUrlFormatter
{
    string GetForIdDetailed(long id);

    string GetForReferenceDetailed(string reference);
}