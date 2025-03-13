using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters;

internal class SurpassUserApiUrlFormatter : SurpassApiUrlFormatter, ISurpassUserApiUrlFormatter
{
    private const string ShowPermissionsParam = "showPermissions=true";

    public SurpassUserApiUrlFormatter(string template)
        : base(template)
    {
    }

    public string GetForQueryString(string queryString, bool includeDetails)
    {
        var detailsParamTemplate = $"includeDetails={includeDetails}";
        return string.Join(
            string.IsNullOrEmpty(queryString) ? string.Empty : "&",
            GetForQueryString(queryString),
            detailsParamTemplate);
    }

    public string GetForId(long id, bool showPermissions = false)
    {
        return showPermissions
            ? string.Join("?", base.GetForId(id), ShowPermissionsParam)
            : base.GetForId(id);
    }

    public string GetForReference(string reference, bool showPermissions = false)
    {
        return showPermissions
            ? string.Join("&", base.GetForReference(reference), ShowPermissionsParam)
            : base.GetForReference(reference);
    }
}