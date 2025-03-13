using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.ItemReview;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ItemReviewTaskResourceController : IItemReviewTaskResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassTaskApiUrlFormatter _apiUrlFormatter;

    internal ItemReviewTaskResourceController(
        IRestApiClient restApiClient,
        ISurpassTaskApiUrlFormatter apiUrlFormatter)
    {
        _restApiClient = restApiClient;
        _apiUrlFormatter = apiUrlFormatter;
    }

    /// <summary>
    /// Get single item review task resource that matches the id.
    /// </summary>
    /// <param name="id">Item review task id</param>
    /// <returns>
    /// Response model that contains item review task slim details.
    /// </returns>
    public TimeZonePageResponse<ItemReviewTaskDetailedSlimResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemReviewTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForId(id));
    }

    /// <summary>
    /// Get single item review task resource that matches the id.
    /// </summary>
    /// <param name="id">Item review task id</param>
    /// <returns>
    /// Response model that contains item review task extended details.
    /// </returns>
    public TimeZonePageResponse<ItemReviewTaskDetailedExtendedResource> GetDetailed(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemReviewTaskDetailedExtendedResource>>(
            _apiUrlFormatter.GetForIdDetailed(id));
    }

    /// <summary>
    /// Get single item review task resource that matches the reference.
    /// </summary>
    /// <param name="reference">Item review task reference</param>
    /// <returns>
    /// Response model that contains item review task slim details.
    /// </returns>
    public TimeZonePageResponse<ItemReviewTaskDetailedSlimResource> GetByReference(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemReviewTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForReference(reference));
    }

    /// <summary>
    /// Get single item review task resource that matches the reference.
    /// </summary>
    /// <param name="reference">Item review task reference</param>
    /// <returns>
    /// Response model that contains item review task extended details.
    /// </returns>
    public TimeZonePageResponse<ItemReviewTaskDetailedExtendedResource> GetByReferenceDetailed(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemReviewTaskDetailedExtendedResource>>(
            _apiUrlFormatter.GetForReferenceDetailed(reference));
    }

    /// <summary>
    /// Create item review task resource in the database.
    /// </summary>
    /// <param name="itemReviewTaskCreateResource">Item review task details</param>
    /// <returns>
    /// Response model that contains information about execution result.
    /// </returns>
    public TimeZonePostResponseModel Post(ItemReviewTaskCreateResource itemReviewTaskCreateResource)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, ItemReviewTaskCreateResource>(
            _apiUrlFormatter.Get(),
            itemReviewTaskCreateResource);
    }

    /// <summary>
    /// Update item review task resource in the database using provided data.
    /// </summary>
    /// <param name="id">Task id</param>
    /// <param name="itemReviewTaskUpdateResource">Item review task details</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(
        long id,
        ItemReviewTaskUpdateResource itemReviewTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, ItemReviewTaskUpdateResource>(
            _apiUrlFormatter.GetForId(id),
            itemReviewTaskUpdateResource,
            headers);
    }

    /// <summary>
    /// Update item review task resource in the database using provided data.
    /// </summary>
    /// <param name="reference">Task reference</param>
    /// <param name="itemReviewTaskUpdateResource">Item review task details</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(
        string reference,
        ItemReviewTaskUpdateResource itemReviewTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, ItemReviewTaskUpdateResource>(
            _apiUrlFormatter.GetForReference(reference),
            itemReviewTaskUpdateResource,
            headers);
    }
}