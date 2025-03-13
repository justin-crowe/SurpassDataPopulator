using SurpassApiSdk.DataContracts.HistoricalResult;
using SurpassApiSdk.DataContracts.ItemResponse;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IHistoricalResultController
{
    TimeZonePageResponse<HistoricalResultDetailedResource> Get(int id);

    TimeZonePageResponse<HistoricalResultResource> Get(string queryString = null);

    TimeZonePageResponse<ItemResponseDetailResource> GetItemResponse(int id, string surpassReference);

    TimeZonePageResponse<ItemResponseResource> GetItemResponses(int id, string queryString = null);
}