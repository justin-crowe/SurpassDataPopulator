using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassBasicPageApiUrlFormatter : SurpassApiUrlFormatter, ISurpassBasicPageApiUrlFormatter
    {
        public SurpassBasicPageApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForIdAssistiveId(long id, long assistiveId)
        {
            return $"{GetForId(id)}/AssistiveMedia/{assistiveId}";
        }
    }
}
