namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassUserApiUrlFormatter : ISurpassApiUrlFormatter
{
    string GetForQueryString(string queryString, bool includeDetails);

    string GetForId(long id, bool showPermissions = false);

    string GetForReference(string reference, bool showPermissions = false);
}