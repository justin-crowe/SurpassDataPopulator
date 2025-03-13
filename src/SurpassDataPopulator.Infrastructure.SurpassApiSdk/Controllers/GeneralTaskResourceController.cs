using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.General;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class GeneralTaskResourceController : IGeneralTaskResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassTaskApiUrlFormatter _apiUrlFormatter;

    internal GeneralTaskResourceController(
        IRestApiClient restApiClient,
        ISurpassTaskApiUrlFormatter apiUrlFormatter)
    {
        _restApiClient = restApiClient;
        _apiUrlFormatter = apiUrlFormatter;
    }

    /// <summary>
    /// Get single general task resource that matches the id.
    /// </summary>
    /// <param name="id">General task id</param>
    /// <returns>
    /// Response model that contains general task slim details.
    /// </returns>
    public TimeZonePageResponse<GeneralTaskDetailedSlimResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<GeneralTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForId(id));
    }

    /// <summary>
    /// Get single general task resource that matches the id.
    /// </summary>
    /// <param name="id">General task id</param>
    /// <returns>
    /// Response model that contains general task extended details.
    /// </returns>
    public TimeZonePageResponse<GeneralTaskDetailedExtendedResource> GetDetailed(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<GeneralTaskDetailedExtendedResource>>(
            _apiUrlFormatter.GetForIdDetailed(id));
    }

    /// <summary>
    /// Get single general task resource that matches the reference.
    /// </summary>
    /// <param name="reference">General task reference</param>
    /// <returns>
    /// Response model that contains general task slim details.
    /// </returns>
    public TimeZonePageResponse<GeneralTaskDetailedSlimResource> GetByReference(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<GeneralTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForReference(reference));
    }

    /// <summary>
    /// Get single general task resource that matches the reference.
    /// </summary>
    /// <param name="reference">General task reference</param>
    /// <returns>
    /// Response model that contains general task extended details.
    /// </returns>
    public TimeZonePageResponse<GeneralTaskDetailedExtendedResource> GetByReferenceDetailed(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<GeneralTaskDetailedExtendedResource>>(
            _apiUrlFormatter.GetForReferenceDetailed(reference));
    }

    /// <summary>
    /// Create general task resource in the database.
    /// </summary>
    /// <param name="generalTaskCreateResource">General task details</param>
    /// <returns>
    /// Response model that contains information about execution result.
    /// </returns>
    public TimeZonePostResponseModel Post(GeneralTaskCreateResource generalTaskCreateResource)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, GeneralTaskCreateResource>(
            _apiUrlFormatter.Get(),
            generalTaskCreateResource);
    }

    /// <summary>
    /// Update general task resource in the database using provided data.
    /// </summary>
    /// <param name="id">Task id</param>
    /// <param name="generalTaskUpdateResource">Task details</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(
        long id,
        GeneralTaskUpdateResource generalTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, GeneralTaskUpdateResource>(
            _apiUrlFormatter.GetForId(id),
            generalTaskUpdateResource,
            headers);
    }

    /// <summary>
    /// Update general task resource in the database using provided data.
    /// </summary>
    /// <param name="reference">Task reference</param>
    /// <param name="generalTaskUpdateResource">Task details</param>
    /// <param name="headers">Request headers</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(
        string reference,
        GeneralTaskUpdateResource generalTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, GeneralTaskUpdateResource>(
            _apiUrlFormatter.GetForReference(reference),
            generalTaskUpdateResource,
            headers);
    }
}