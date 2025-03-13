using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.HistoricalResult;
using SurpassApiSdk.DataContracts.ItemResponse;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class HistoricalResultController : IHistoricalResultController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassResultApiUrlFormatter _urlFormatter;

    internal HistoricalResultController(IRestApiClient restApiClient, ISurpassResultApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    public TimeZonePageResponse<HistoricalResultDetailedResource> Get(int id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<HistoricalResultDetailedResource>>(
            _urlFormatter.GetForId(id));
    }

    public TimeZonePageResponse<HistoricalResultResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<HistoricalResultResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    public TimeZonePageResponse<ItemResponseDetailResource> GetItemResponse(int id, string surpassReference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseDetailResource>>(
            _urlFormatter.GetForResultIdItemId(id, surpassReference));
    }

    public TimeZonePageResponse<ItemResponseResource> GetItemResponses(int id, string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseResource>>(
            _urlFormatter.GetManyResultsForId(id, queryString));
    }
}