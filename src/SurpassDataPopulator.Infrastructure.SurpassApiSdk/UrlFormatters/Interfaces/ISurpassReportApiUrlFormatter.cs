namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassReportApiUrlFormatter : ISurpassApiUrlFormatter
    {
        string GetForReportParameters(int id, IDictionary<string, object> parameters, bool inculdeGenerate = true);
    }
}
