using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.StandardSetting;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class StandardSettingResultResourceController : IStandardSettingResultResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassItemReviewResultApiUrlFormatter _apiUrlFormatter;

    internal StandardSettingResultResourceController(
        IRestApiClient restApiClient,
        ISurpassItemReviewResultApiUrlFormatter apiUrlFormatter)
    {
        _restApiClient = restApiClient;
        _apiUrlFormatter = apiUrlFormatter;
    }

    /// <summary>
    /// Get list of Standard Setting result resources that matches the task.
    /// </summary>
    /// <param name="taskId">Item review task id</param>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains Standard Setting result slim details.
    /// </returns>
    public TimeZonePageResponse<StandardSettingResultResource> Get(long taskId, string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StandardSettingResultResource>>(
            _apiUrlFormatter.GetForItemReviewResults(taskId, queryString));
    }

    /// <summary>
    /// Get list of item review result resources that matches the task.
    /// </summary>
    /// <param name="taskReference">Item review task reference</param>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains Standard Setting result slim details.
    /// </returns>
    public TimeZonePageResponse<StandardSettingResultResource> Get(string taskReference, string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StandardSettingResultResource>>(
            _apiUrlFormatter.GetForItemReviewResults(taskReference, queryString));
    }

    /// <summary>
    /// Get single Standard Setting result resource that matches the id.
    /// </summary>
    /// <param name="id">Item review result id</param>
    /// <returns>
    /// Response model that contains item review result extended details.
    /// </returns>
    public TimeZonePageResponse<StandardSettingResultDetailedResource> GetDetailed(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StandardSettingResultDetailedResource>>(
            _apiUrlFormatter.GetForItemReviewResult(id));
    }

    /// <summary>
    /// Update item review result resource in the database using provided data.
    /// </summary>
    /// <param name="id">Result id</param>
    /// <param name="standardSettingResultUpdateResource">Standard Setting task details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(
        long id,
        StandardSettingResultUpdateResource standardSettingResultUpdateResource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, StandardSettingResultUpdateResource>(
            _apiUrlFormatter.GetForId(id),
            standardSettingResultUpdateResource,
            null);
    }
}