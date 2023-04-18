using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Report;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class ReportResourceController : IReportResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassReportApiUrlFormatter _urlFormatter;

        internal ReportResourceController(IRestApiClient restApiClient, ISurpassReportApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all report info resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all report info resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<ReportInfoResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<ReportInfoResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single report info resource that matches the id.
        /// </summary>
        /// <param name="id">Report id</param>
        /// <returns>
        /// Response model that contains report info details.
        /// </returns>
        public TimeZonePageResponse<ReportInfoResourceWithParameters> GetReportInfo(int id)
        {
            return GetReport<ReportInfoResourceWithParameters>(id, new Dictionary<string, object>(), false);
        }

        /// <summary>
        /// Get single report data resource that matches the id and parameters.
        /// </summary>
        /// <param name="id">Report id</param>
        /// <param name="parameters">
        /// Report filter parameters.
        /// </param>
        /// <returns>
        /// Response model that contains report data details.
        /// </returns>
        public TimeZonePageResponse<ReportDataResource> GetData(int id, IDictionary<string, object> parameters)
        {
            return GetReport<ReportDataResource>(id, parameters);
        }

        private TimeZonePageResponse<T> GetReport<T>(
            int reportId,
            IDictionary<string, object> parameters,
            bool inculdeGenerate = true)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<T>>(
                _urlFormatter.GetForReportParameters(reportId, parameters, inculdeGenerate));
        }
    }
}
