using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassCustomReportApiUrlFormatter : SurpassApiUrlFormatter, ISurpassCustomReportApiUrlFormatter
    {
        public SurpassCustomReportApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForCheckReferenceUniqueness(string reference)
        {
            return $"{Template}/CheckReferenceUniqueness?reference={reference}";
        }

        public string GetForFileGeneration()
        {
            return $"{Template}/file";
        }

        public string GetForHtmlGeneration()
        {
            return $"{Template}/html";
        }

        public string GetForWrappedHtmlGeneration()
        {
            return $"{Template}/wrappedhtml";
        }
    }
}
