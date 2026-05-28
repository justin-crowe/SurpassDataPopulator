using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.AnalyticsResult;
using SurpassApiSdk.DataContracts.ItemResponse;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class AnalyticsResultResourceController : IAnalyticsResultResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassResultApiUrlFormatter _urlFormatter;

    internal AnalyticsResultResourceController(
        IRestApiClient restApiClient,
        ISurpassResultApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    public TimeZonePageResponse<AnalyticsResultDetailedResource> Get(int id, bool showItemResponses = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<AnalyticsResultDetailedResource>>(
            _urlFormatter.GetForId(id, showItemResponses));
    }

    public TimeZonePageResponse<AnalyticsResultResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<AnalyticsResultResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    public TimeZonePageResponse<AnalyticsResultDetailedResource> GetByKeycode(
        string keycode,
        bool showItemResponses = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<AnalyticsResultDetailedResource>>(
            _urlFormatter.GetForKeycode(keycode, showItemResponses));
    }

    public TimeZonePageResponse<ItemResponseResource> GetItemResponsesByKeycode(string keycode)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseResource>>(
            _urlFormatter.GetManyResultsForKeycode(keycode));
    }

    public TimeZonePageResponse<ItemResponseResource> GetItemResponsesById(int id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseResource>>(
            _urlFormatter.GetManyResultsForId(id));
    }

    public TimeZonePageResponse<ItemResponseDetailResource> GetItemResponseById(int id, string surpassReference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseDetailResource>>(
            _urlFormatter.GetForResultIdItemId(id, surpassReference));
    }

    public TimeZonePageResponse<ItemResponseDetailResource> GetItemResponseByKeycode(
        string keycode,
        string surpassReference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseDetailResource>>(
            _urlFormatter.GetForResultKeycodeItemId(keycode, surpassReference));
    }
}