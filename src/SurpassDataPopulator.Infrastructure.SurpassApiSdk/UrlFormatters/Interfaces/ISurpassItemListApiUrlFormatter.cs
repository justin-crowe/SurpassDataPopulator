namespace SurpassApiSdk.UrlFormatters.Interfaces;

internal interface ISurpassItemListApiUrlFormatter : ISurpassApiUrlFormatter
{
    string GetForId(int id, bool permanent);

    string GetForReference(string keycode, bool permanent);
}