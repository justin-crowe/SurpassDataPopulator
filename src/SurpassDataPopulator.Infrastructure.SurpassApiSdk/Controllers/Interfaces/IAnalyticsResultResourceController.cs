using SurpassApiSdk.DataContracts.AnalyticsResult;
using SurpassApiSdk.DataContracts.ItemResponse;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IAnalyticsResultResourceController
    {
#pragma warning disable CA1716 // Keep for backward compatibility
        TimeZonePageResponse<AnalyticsResultDetailedResource> Get(int id, bool showItemResponses = false);
#pragma warning restore CA1716 // Keep for backward compatibility

#pragma warning disable CA1716 // Keep for backward compatibility
        TimeZonePageResponse<AnalyticsResultResource> Get(string queryString = null);
#pragma warning restore CA1716 // Keep for backward compatibility

        TimeZonePageResponse<ItemResponseResource> GetItemResponsesByKeycode(string keycode);

        TimeZonePageResponse<ItemResponseResource> GetItemResponsesById(int id);

        TimeZonePageResponse<ItemResponseDetailResource> GetItemResponseById(int id, string surpassReference);

        TimeZonePageResponse<ItemResponseDetailResource> GetItemResponseByKeycode(
            string keycode,
            string surpassReference);

        TimeZonePageResponse<AnalyticsResultDetailedResource> GetByKeycode(
            string keycode,
            bool showItemResponses = false);
    }
}
