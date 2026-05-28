using System.Globalization;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters;

internal class SurpassLanguageVariantApiUrlFormatter : ISurpassLanguageVariantApiUrlFormatter
{
    public SurpassLanguageVariantApiUrlFormatter(string template)
    {
        Template = template;
    }

    public string Template { get; }

    public string GetForParentId(int id)
    {
        return string.Format(CultureInfo.InvariantCulture, Template, id);
    }

    public string GetForIdAndCode(int id, string code)
    {
        return $"{string.Format(CultureInfo.InvariantCulture, Template, id)}/{code}";
    }
}