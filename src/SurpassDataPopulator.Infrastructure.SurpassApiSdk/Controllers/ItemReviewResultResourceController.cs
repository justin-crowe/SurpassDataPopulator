using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.ItemReview;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ItemReviewResultResourceController : IItemReviewResultResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassItemReviewResultApiUrlFormatter _apiUrlFormatter;

    internal ItemReviewResultResourceController(
        IRestApiClient restApiClient,
        ISurpassItemReviewResultApiUrlFormatter apiUrlFormatter)
    {
        _restApiClient = restApiClient;
        _apiUrlFormatter = apiUrlFormatter;
    }

    /// <summary>
    /// Get list of item review result resources that matches the task.
    /// </summary>
    /// <param name="taskId">Item review task id</param>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains item review result slim details.
    /// </returns>
    public TimeZonePageResponse<ItemReviewResultResource> Get(long taskId, string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemReviewResultResource>>(
            _apiUrlFormatter.GetForItemReviewResults(taskId, queryString));
    }

    /// <summary>
    /// Get list of item review result resources that matches the task.
    /// </summary>
    /// <param name="taskReference">Item review task reference</param>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains item review result slim details.
    /// </returns>
    public TimeZonePageResponse<ItemReviewResultResource> Get(string taskReference, string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemReviewResultResource>>(
            _apiUrlFormatter.GetForItemReviewResults(taskReference, queryString));
    }

    /// <summary>
    /// Get single item review result resource that matches the id.
    /// </summary>
    /// <param name="id">Item review result id</param>
    /// <returns>
    /// Response model that contains item review result extended details.
    /// </returns>
    public TimeZonePageResponse<ItemReviewResultDetailedResource> GetDetailed(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemReviewResultDetailedResource>>(
            _apiUrlFormatter.GetForItemReviewResult(id));
    }

    /// <summary>
    /// Update item review result resource in the database using provided data.
    /// </summary>
    /// <param name="id">Result id</param>
    /// <param name="itemReviewResultUpdateResource">Item review task details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(long id, ItemReviewResultUpdateResource itemReviewResultUpdateResource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, ItemReviewResultUpdateResource>(
            _apiUrlFormatter.GetForId(id),
            itemReviewResultUpdateResource,
            null);
    }
}