using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.SummaryResult;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class SummaryResultResourceController : ISummaryResultResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassResultApiUrlFormatter _urlFormatter;

    internal SummaryResultResourceController(
        IRestApiClient restApiClient,
        ISurpassResultApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all summary result resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <param name="markedExternally">Marked externally parameter</param>
    /// <param name="includeExamsInMarking">Include results awaiting marking in SecureMarker</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all summary result resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<SummaryResultResource> Get(
        string queryString = null,
        bool markedExternally = false,
        bool includeExamsInMarking = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<SummaryResultResource>>(
            _urlFormatter.GetForQueryString(queryString, markedExternally, includeExamsInMarking));
    }

    /// <summary>
    /// Get single summary result resource that matches the id.
    /// </summary>
    /// <param name="id">Summary result id</param>
    /// <returns>
    /// Response model that contains summary result details.
    /// </returns>
    public TimeZonePageResponse<SummaryResultDetailedResource> Get(int id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<SummaryResultDetailedResource>>(
            _urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Get single summary result resource that matches the keycode.
    /// </summary>
    /// <param name="keycode">Summary result keycode</param>
    /// <returns>
    /// Response model that contains summary result details.
    /// </returns>
    public TimeZonePageResponse<SummaryResultDetailedResource> GetByKeyCode(string keycode)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<SummaryResultDetailedResource>>(
            _urlFormatter.GetForKeycode(keycode));
    }
}