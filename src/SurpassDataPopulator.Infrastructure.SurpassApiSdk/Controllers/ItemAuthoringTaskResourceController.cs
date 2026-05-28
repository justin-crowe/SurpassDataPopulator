using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.ItemAuthoring;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ItemAuthoringTaskResourceController : IItemAuthoringTaskResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassTaskApiUrlFormatter _apiUrlFormatter;

    internal ItemAuthoringTaskResourceController(
        IRestApiClient restApiClient,
        ISurpassTaskApiUrlFormatter apiUrlFormatter)
    {
        _restApiClient = restApiClient;
        _apiUrlFormatter = apiUrlFormatter;
    }

    public TimeZonePageResponse<ItemAuthoringTaskDetailedSlimResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemAuthoringTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForId(id));
    }

    public TimeZonePageResponse<ItemAuthoringTaskDetailedSlimResource> GetByReference(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemAuthoringTaskDetailedSlimResource>>(
            _apiUrlFormatter.GetForReference(reference));
    }

    public TimeZonePageResponse<ItemAuthoringTaskDetailedExtendedResource> GetDetailed(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemAuthoringTaskDetailedExtendedResource>>(
            _apiUrlFormatter.GetForIdDetailed(id));
    }

    public TimeZonePageResponse<ItemAuthoringTaskDetailedExtendedResource> GetByReferenceDetailed(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<ItemAuthoringTaskDetailedExtendedResource>>(
            _apiUrlFormatter.GetForReferenceDetailed(reference));
    }

    public TimeZonePostResponseModel Post(ItemAuthoringTaskCreateResource itemAuthoringTaskCreateResource)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, ItemAuthoringTaskCreateResource>(
            _apiUrlFormatter.Get(),
            itemAuthoringTaskCreateResource);
    }

    public TimeZonePostResponseModel Put(long id, ItemAuthoringTaskUpdateResource itemAuthoringTaskUpdateResource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, ItemAuthoringTaskUpdateResource>(
            _apiUrlFormatter.GetForId(id),
            itemAuthoringTaskUpdateResource);
    }

    public TimeZonePostResponseModel Put(
        string reference,
        ItemAuthoringTaskUpdateResource itemAuthoringTaskUpdateResource)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, ItemAuthoringTaskUpdateResource>(
            _apiUrlFormatter.GetForReference(reference),
            itemAuthoringTaskUpdateResource);
    }
}