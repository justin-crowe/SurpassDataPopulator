using System.Globalization;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassItemListApiUrlFormatter : SurpassApiUrlFormatter, ISurpassItemListApiUrlFormatter
    {
        private const string PermanentParameter = "permanent={0}";

        public SurpassItemListApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForId(int id, bool permanent)
        {
            var queryString = GetQueryString(permanent);
            var baseUrl = string.Join("/", Template, id);

            return string.Join("?", baseUrl, queryString);
        }

        public string GetForReference(string keycode, bool permanent)
        {
            var queryString = GetQueryString(permanent);
            var baseUrl = string.Join("/", Template, keycode);

            return string.Join("?", baseUrl, queryString);
        }

        #region Private

        private static string GetQueryString(bool permanent)
        {
            return string.Format(CultureInfo.InvariantCulture, PermanentParameter, permanent.ToString(CultureInfo.InvariantCulture).ToLower());
        }

        #endregion
    }
}
