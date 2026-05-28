using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.ItemSet;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ItemSetResourceController : IItemSetResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal ItemSetResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all ItemSet resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string of string empty</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all ItemSet resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<ItemSetResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemSetResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    /// <summary>
    /// Get single ItemSet resource that matches the id.
    /// </summary>
    /// <param name="id">ItemSet id</param>
    /// <returns>
    /// Response model that contains ItemSet details.
    /// </returns>
    public TimeZonePageResponse<ItemSetResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemSetResource>>(_urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Create ItemSet using provided data.
    /// </summary>
    /// <param name="itemSet">Item set input data</param>
    /// <returns>Response model that contains information about the execution result.</returns>
    public PostResponseModel Post(ItemSetInputResource itemSet)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, ItemSetInputResource>(
            _urlFormatter.Get(),
            itemSet);
    }

    /// <summary>
    /// Update ItemSet by the given id using provided data.
    /// </summary>
    /// <param name="id">The identifier of the item set being updated</param>
    /// <param name="itemSet">Item set update data</param>
    /// <returns>Response model that contains information about the execution result.</returns>
    public PostResponseModel Put(long id, ItemSetUpdateResource itemSet)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, ItemSetUpdateResource>(
            _urlFormatter.GetForId(id),
            itemSet);
    }

    /// <summary>
    /// Delete ItemSet from the database using provided data.
    /// </summary>
    /// <param name="id">Item id</param>
    /// <returns>Response model that contains information about the execution result.</returns>
    public ItemDeleteTimeZonePostResponseModel Delete(long id)
    {
        return _restApiClient.CallDelete<ItemDeleteTimeZonePostResponseModel>(_urlFormatter.GetForId(id));
    }
}