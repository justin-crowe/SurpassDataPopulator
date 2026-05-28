namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassLanguageVariantApiUrlFormatter
{
    string GetForParentId(int id);

    string GetForIdAndCode(int id, string code);
}