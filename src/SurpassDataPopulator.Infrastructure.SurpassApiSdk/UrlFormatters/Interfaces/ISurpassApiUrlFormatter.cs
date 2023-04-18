namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassApiUrlFormatter
    {
        string Get();

        string GetForId(int id);

        string GetForId(long id);

        string GetForKeycode(string keycode);

        string GetForQueryString(string queryString);

        string GetForReference(string reference);

        string GetForDataById(int id);
    }
}
