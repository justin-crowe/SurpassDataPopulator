using SurpassApiSdk.DataContracts.Report;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IReportResourceController
{
    TimeZonePageResponse<ReportInfoResource> Get(string queryString = null);

    TimeZonePageResponse<ReportDataResource> GetData(int id, IDictionary<string, object> parameters);

    TimeZonePageResponse<ReportInfoResourceWithParameters> GetReportInfo(int id);
}