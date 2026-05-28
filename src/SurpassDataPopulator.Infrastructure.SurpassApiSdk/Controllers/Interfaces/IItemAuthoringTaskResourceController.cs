using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.ItemAuthoring;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IItemAuthoringTaskResourceController
{
    TimeZonePageResponse<ItemAuthoringTaskDetailedSlimResource> Get(long id);

    TimeZonePageResponse<ItemAuthoringTaskDetailedExtendedResource> GetDetailed(long id);

    TimeZonePageResponse<ItemAuthoringTaskDetailedSlimResource> GetByReference(string reference);

    //TimeZonePostResponseModel Post([FromBody] ItemAuthoringTaskCreateResource itemAuthoringTaskCreateResource);

    TimeZonePostResponseModel Put(long id, ItemAuthoringTaskUpdateResource itemAuthoringTaskUpdateResource);

    TimeZonePostResponseModel Put(
        string reference,
        ItemAuthoringTaskUpdateResource itemAuthoringTaskUpdateResource);
}