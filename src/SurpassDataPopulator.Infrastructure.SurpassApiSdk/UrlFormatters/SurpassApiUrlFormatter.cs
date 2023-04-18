using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassApiUrlFormatter : ISurpassApiUrlFormatter
    {
        public SurpassApiUrlFormatter(string template)
        {
            Template = template;
        }

        protected string Template { get; }

        public string Get()
        {
            return Template;
        }

        public string GetForId(int id)
        {
            return string.Join("/", Template, id);
        }

        public string GetForId(long id)
        {
            return string.Join("/", Template, id);
        }

        public string GetForKeycode(string keycode)
        {
            return string.Join("/", Template, keycode);
        }

        public string GetForQueryString(string queryString)
        {
            return string.Join("?", Template, queryString);
        }

        public string GetForReference(string reference)
        {
            return GetForQueryString($"reference={reference}");
        }

        public string GetForDataById(int id)
        {
            return string.Join("/", Template, id, "Data");
        }
    }
}
