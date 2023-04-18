using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassTestApiUrlFormatter : SurpassApiUrlFormatter, ISurpassTestUrlFormatter
    {
        public SurpassTestApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetManyTestFormsForTestId(long id, string queryString = null, bool scheduledTestFormsOnly = false)
        {
            return
                $"{GetForId(id)}/TestForms/{GetForQueryStringWithScheduledTestFormsOnly(queryString, scheduledTestFormsOnly)}";
        }

        public string GetManyTestFormsForTestReference(
            string reference,
            string queryString = null,
            bool scheduledTestFormsOnly = false)
        {
            return
                $"{GetForKeycode(reference)}/TestForms/{GetForQueryStringWithScheduledTestFormsOnly(queryString, scheduledTestFormsOnly)}";
        }

        private string GetForQueryStringWithScheduledTestFormsOnly(
            string queryString,
            bool scheduledTestFormsOnly = false)
        {
            queryString = (queryString ?? string.Empty).Trim();
            var result = scheduledTestFormsOnly
                ? $"?scheduledTestFormsOnly=true&{queryString}"
                : "?" + queryString;

            return result;
        }
    }
}
