using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters;

internal class SurpassTaskApiUrlFormatter : SurpassApiUrlFormatter, ISurpassTaskApiUrlFormatter
{
    private const string IncludeDetails = "includeDetails=true";

    public SurpassTaskApiUrlFormatter(string template)
        : base(template)
    {
    }

    public string GetForIdDetailed(long id)
    {
        return $"{GetForId(id)}?{IncludeDetails}";
    }

    public string GetForReferenceDetailed(string reference)
    {
        return $"{GetForReference(reference)}&{IncludeDetails}";
    }
}