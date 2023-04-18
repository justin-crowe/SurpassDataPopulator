using System.Globalization;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters
{
    internal class SurpassReportApiUrlFormatter : SurpassApiUrlFormatter, ISurpassReportApiUrlFormatter
    {
        public SurpassReportApiUrlFormatter(string template)
            : base(template)
        {
        }

        public string GetForReportParameters(
            int id,
            IDictionary<string, object> parameters,
            bool inculdeGenerate = true)
        {
            var generateParam = inculdeGenerate ? "&generate=true" : string.Empty;
            var queryString = $"ID={id}{generateParam}";
            foreach (var parameter in parameters)
            {
                var val = parameter.Value.ToString();
                queryString += SerializeToQueryString(parameter, val);
            }

            return GetForQueryString(queryString);
        }

        private static string SerializeToQueryString(KeyValuePair<string, object> parameter, string val)
        {
            if (parameter.Value is Array)
            {
                var arrayOfRefs = ((Array)parameter.Value).AsQueryable().OfType<string>().ToList();
                var parameterValue = string.Empty;
                foreach (var reference in arrayOfRefs)
                {
                    if (!string.IsNullOrEmpty(parameterValue))
                    {
                        parameterValue += ",";
                    }

                    parameterValue += $"%22{reference}%22";
                }

                val = $"{{{parameterValue}}}";
            }

            if (parameter.Value is DateTime)
            {
                val = ((DateTime)parameter.Value).ToString("yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            }

            return $"&{parameter.Key}={val}";
        }
    }
}
