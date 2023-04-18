using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassItemApiUrlFormatter : SurpassBasicPageApiUrlFormatter, ISurpassItemApiUrlFormatter
    {
        public SurpassItemApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForQueryString(string queryString, bool includeDeleted)
        {
            return GetForQueryString(
                includeDeleted
                    ? $"includeDeleted=true&{queryString}"
                    : queryString);
        }
    }
}
