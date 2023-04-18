using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassTestFormUrlFormatter : SurpassApiUrlFormatter, ISurpassTestFormUrlFormatter
    {
        private const string IncludeItemsParam = "includeItems=true";

        public SurpassTestFormUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForSectionId(int testFormId, int sectionId)
        {
            return $"{GetForId(testFormId)}/Section/{sectionId}";
        }

        public string GetForSectionId(string testFormRef, int sectionId)
        {
            return $"{GetForRef(testFormRef)}/Section/{sectionId}";
        }

        public string GetForRef(string reference, bool includeItems = false)
        {
            var baseGet = string.Join("/", Template, reference);
            return includeItems ? $"{baseGet}?{IncludeItemsParam}" : baseGet;
        }

        public string GetForId(int id, bool includeItems = false)
        {
            var baseGet = base.GetForId(id);
            return includeItems ? $"{baseGet}?{IncludeItemsParam}" : baseGet;
        }
    }
}
