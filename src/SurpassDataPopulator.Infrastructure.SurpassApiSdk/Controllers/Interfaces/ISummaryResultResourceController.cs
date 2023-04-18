using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.SummaryResult;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ISummaryResultResourceController
    {
        TimeZonePageResponse<SummaryResultDetailedResource> Get(int id);

        TimeZonePageResponse<SummaryResultResource> Get(
            string queryString = null,
            bool markedExternally = false,
            bool includeExamsInMarking = false);

        TimeZonePageResponse<SummaryResultDetailedResource> GetByKeyCode(string keycode);
    }
}
