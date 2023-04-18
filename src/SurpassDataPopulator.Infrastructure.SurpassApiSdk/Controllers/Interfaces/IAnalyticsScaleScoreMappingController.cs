using SurpassApiSdk.DataContracts.AnalyticsScaleScoreMappingResult;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IAnalyticsScaleScoreMappingController
    {
        TimeZonePageResponse<AnalyticsScaleScoreMappingDetailedResource> Get(int id);
    }
}
