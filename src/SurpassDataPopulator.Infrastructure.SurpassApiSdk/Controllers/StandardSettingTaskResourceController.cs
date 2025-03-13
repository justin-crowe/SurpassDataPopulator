using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.StandardSetting;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class StandardSettingTaskResourceController : IStandardSettingTaskResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassTaskApiUrlFormatter _apiUrlFormatter;

    internal StandardSettingTaskResourceController(
        IRestApiClient restApiClient,
        ISurpassTaskApiUrlFormatter apiUrlFormatter)
    {
        _restApiClient = restApiClient;
        _apiUrlFormatter = apiUrlFormatter;
    }

    public TimeZonePageResponse<StandardSettingTaskDetailedSlimResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StandardSettingTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForId(id));
    }

    public TimeZonePageResponse<StandardSettingTaskDetailedSlimResource> GetByReference(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StandardSettingTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForReference(reference));
    }

    public TimeZonePageResponse<StandardSettingTaskDetailedResource> GetDetailed(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<StandardSettingTaskDetailedResource>>(
            _apiUrlFormatter.GetForIdDetailed(id));
    }

    public TimeZonePostResponseModel Post(StandardSettingTaskCreateResource standardSettingTaskCreateResource)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, StandardSettingTaskCreateResource>(
            _apiUrlFormatter.Get(),
            standardSettingTaskCreateResource);
    }

    public TimeZonePostResponseModel Put(
        long id,
        StandardSettingTaskUpdateResource standardSettingTaskUpdateResource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, StandardSettingTaskUpdateResource>(
            _apiUrlFormatter.GetForId(id),
            standardSettingTaskUpdateResource);
    }

    public TimeZonePostResponseModel Put(
        string reference,
        StandardSettingTaskUpdateResource standardSettingTaskUpdateResource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, StandardSettingTaskUpdateResource>(
            _apiUrlFormatter.GetForReference(reference),
            standardSettingTaskUpdateResource);
    }
}