using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.CandidateInteraction;
using SurpassApiSdk.DataContracts.ClientInformation;
using SurpassApiSdk.DataContracts.ItemResponse;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.DataContracts.StateChanges;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ResultResourceController : IResultResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassResultApiUrlFormatter _urlFormatter;

    internal ResultResourceController(IRestApiClient restApiClient, ISurpassResultApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all result resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <param name="markedExternally">Marked externally parameter</param>
    /// <param name="includeExamsInMarking">Include results awaiting marking in SecureMarker</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all result resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<ResultResource> Get(
        string queryString = null,
        bool markedExternally = false,
        bool includeExamsInMarking = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ResultResource>>(
            _urlFormatter.GetForQueryString(queryString, markedExternally, includeExamsInMarking));
    }

    /// <summary>
    /// Get single result resource that matches the id.
    /// </summary>
    /// <param name="id">Result id</param>
    /// <param name="showItemResponses">Show item responses parameter</param>
    /// <returns>
    /// Response model that contains result details.
    /// </returns>
    public TimeZonePageResponse<ResultDetailedResource> Get(
        int id,
        bool showItemResponses = false,
        bool returnDownloadData = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ResultDetailedResource>>(
            _urlFormatter.GetForId(id, showItemResponses, returnDownloadData: returnDownloadData));
    }

    /// <summary>
    /// Get single result resource that matches the keycode.
    /// </summary>
    /// <param name="keycode">Result keycode</param>
    /// <param name="showItemResponses">Show item responses parameter</param>
    /// <returns>
    /// Response model that contains result details.
    /// </returns>
    public TimeZonePageResponse<ResultDetailedResource> GetByKeycode(
        string keycode,
        bool showItemResponses = false,
        bool showAnalysis = false,
        bool returnDownloadData = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ResultDetailedResource>>(
            _urlFormatter.GetForKeycode(keycode, showItemResponses, showAnalysis, returnDownloadData));
    }

    /// <summary>
    /// Get all item response resources that match the query string.
    /// </summary>
    /// <param name="id">Result id</param>
    /// <param name="queryString">OData query string</param>
    /// <param name="markedExternally">Marked externally parameter</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all item response resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<ItemResponseResource> GetItemResponses(
        int id,
        string queryString = null,
        bool markedExternally = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseResource>>(
            _urlFormatter.GetManyResultsForId(id, queryString, markedExternally));
    }

    /// <summary>
    /// Get all item response resources that match the query string.
    /// </summary>
    /// <param name="keycode">Result keycode</param>
    /// <param name="queryString">OData query string</param>
    /// <param name="markedExternally">Marked externally parameter</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all item response resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<ItemResponseResource> GetItemResponses(
        string keycode,
        string queryString = null,
        bool markedExternally = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseResource>>(
            _urlFormatter.GetManyResultsForKeycode(keycode, queryString, markedExternally));
    }

    /// <summary>
    /// Get single item response resource that matches the result id/ surpassReference.
    /// </summary>
    /// <param name="id">Result id</param>
    /// <param name="surpassReference">Item id</param>
    /// <returns>
    /// Response model that contains result details.
    /// </returns>
    public TimeZonePageResponse<ItemResponseDetailResource> GetItemResponse(int id, string surpassReference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseDetailResource>>(
            _urlFormatter.GetForResultIdItemId(id, surpassReference));
    }

    /// <summary>
    /// Get single result resource that matches the keycode.
    /// </summary>
    /// <param name="keycode">Result keycode</param>
    /// <param name="surpassReference">Item id</param>
    /// <returns>
    /// Response model that contains result details.
    /// </returns>
    public TimeZonePageResponse<ItemResponseDetailResource> GetItemResponse(string keycode, string surpassReference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResponseDetailResource>>(
            _urlFormatter.GetForResultKeycodeItemId(keycode, surpassReference));
    }

    /// <summary>
    /// Get the candidate interactions for the result by id.
    /// </summary>
    /// <param name="id">The session id.</param>
    public TimeZonePageResponse<CandidateInteractionResource> GetCandidateInteraction(
        int id,
        bool includeDebugEvents = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CandidateInteractionResource>>(
            _urlFormatter.GetForCandidateInteraction(id, includeDebugEvents));
    }

    /// <summary>
    /// Get the candidate interactions for the result by keycode.
    /// </summary>
    /// <param name="keycode">The session keycode.</param>
    public TimeZonePageResponse<CandidateInteractionResource> GetCandidateInteraction(
        string keycode,
        bool includeDebugEvents = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CandidateInteractionResource>>(
            _urlFormatter.GetForCandidateInteraction(keycode, includeDebugEvents));
    }

    /// <summary>
    /// Get Client Information for provided Result ID
    /// </summary>
    /// <param name="id">Result ID</param>
    /// <returns>
    /// Response model that contains client information.
    /// </returns>
    public TimeZonePageResponse<ClientInformationResource> GetClientInformation(int id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ClientInformationResource>>(
            _urlFormatter.GetForClientInformation(id));
    }

    /// <summary>
    /// Get Client Information for provided Result Keycode
    /// </summary>
    /// <param name="keycode">Result keycode</param>
    /// <returns>
    /// Response model that contains client information.
    /// </returns>
    public TimeZonePageResponse<ClientInformationResource> GetClientInformation(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ClientInformationResource>>(
            _urlFormatter.GetForClientInformation(reference));
    }

    /// <summary>
    /// Get State Changes for provided Result ID
    /// </summary>
    /// <param name="id">Result ID</param>
    /// <returns>
    /// Response model that contains exam state changes.
    /// </returns>
    public TimeZonePageResponse<StateChangesResource> GetStateChanges(int id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StateChangesResource>>(
            _urlFormatter.GetForStateChanges(id));
    }

    /// <summary>
    /// Get State Changes for provided Result Keycode
    /// </summary>
    /// <param name="keycode">Result keycode</param>
    /// <returns>
    /// Response model that contains exam state changes.
    /// </returns>
    public TimeZonePageResponse<StateChangesResource> GetStateChanges(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StateChangesResource>>(
            _urlFormatter.GetForStateChanges(reference));
    }

    /// <summary>
    /// Get TbsTranslation for provided Result Keycode and Tbs input
    /// </summary>
    /// <param name="keycode">Result keycode</param>
    /// <param name="request">TBS input model with TBS ids and candidateResponse</param>
    /// <returns>
    /// Response model that contains TbsTranslation.
    /// </returns>
    public TimeZonePageResponse<TbsTranslatedResultResource> TbsTranslation(
        string keycode,
        TbsTranslatedInputResultResource request)
    {
        return _restApiClient
            .CallPost<TimeZonePageResponse<TbsTranslatedResultResource>, TbsTranslatedInputResultResource>(
                _urlFormatter.GetForTbsTranslation(keycode),
                request);
    }
}