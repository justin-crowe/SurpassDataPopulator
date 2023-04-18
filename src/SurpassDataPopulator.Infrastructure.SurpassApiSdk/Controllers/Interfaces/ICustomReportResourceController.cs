using SurpassApiSdk.DataContracts.CustomReports;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ICustomReportResourceController
    {
        TimeZonePageResponse<CustomReportLinkedResource> Get(string queryString = null);

        TimeZonePageResponse<CustomReportDetailedResource> Get(long id);

        TimeZonePageResponse<CustomReportDetailedResource> GetByReference(string reference);

        TimeZonePostResponseModel Delete(long id);

        TimeZonePostResponseModel Delete(string reference);
    }
}
