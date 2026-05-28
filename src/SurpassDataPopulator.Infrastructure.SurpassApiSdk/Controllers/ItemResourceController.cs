using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ItemResourceController : IItemResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassItemApiUrlFormatter _urlFormatter;

    internal ItemResourceController(IRestApiClient restApiClient, ISurpassItemApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all item resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <param name="includeDeleted">Flag to specify, should deleted items be considered or not</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all item resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<ItemLinkedResource> Get(string queryString = null, bool includeDeleted = false)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemLinkedResource>>(
            _urlFormatter.GetForQueryString(queryString, includeDeleted));
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public TimeZonePageResponse<ItemResource> Get(int id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemResource>>(_urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Get assistive media resource that matches the item id/ assistive media id.
    /// </summary>
    /// <param name="id">Item id</param>
    /// <param name="assistiveMediaId">Assistive media id</param>
    /// <returns>
    /// Response model that contains assistive media details.
    /// </returns>
    public TimeZonePageResponse<AssistiveMediaResource> GetAssistiveMedia(int id, int assistiveMediaId)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<AssistiveMediaResource>>(
            _urlFormatter.GetForIdAssistiveId(id, assistiveMediaId));
    }

    /// <summary>
    /// Put assistive media resource that matches the item id/ assistive media id.
    /// </summary>
    /// <param name="id">Item id</param>
    /// <param name="assistiveMediaId">Assistive media id</param>
    /// <param name="resource">Assistive media data</param>
    /// <returns></returns>
    public PostResponseModel PutAssistiveMedia(int id, int assistiveMediaId, AssistiveMediaInputResource resource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, AssistiveMediaInputResource>(
            _urlFormatter.GetForIdAssistiveId(id, assistiveMediaId),
            resource);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="itemResource"></param>
    /// <returns></returns>
    public PostResponseModel Post(ItemInputResource itemResource)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, ItemInputResource>(
            _urlFormatter.Get(),
            itemResource);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="id"></param>
    /// <param name="itemResource"></param>
    /// <returns></returns>
    public PostResponseModel Put(int id, ItemUpdateResource itemResource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, ItemUpdateResource>(
            _urlFormatter.GetForId(id),
            itemResource);
    }

    /// <summary>
    /// Delete item from the database using provided data.
    /// </summary>
    /// <param name="id">Item id</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public ItemDeleteTimeZonePostResponseModel Delete(int id)
    {
        return _restApiClient.CallDelete<ItemDeleteTimeZonePostResponseModel>(_urlFormatter.GetForId(id));
    }
}