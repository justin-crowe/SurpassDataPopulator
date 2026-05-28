using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.StandardSetting;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IStandardSettingTaskResourceController
{
    TimeZonePageResponse<StandardSettingTaskDetailedSlimResource> Get(long id);

    TimeZonePageResponse<StandardSettingTaskDetailedResource> GetDetailed(long id);

    TimeZonePageResponse<StandardSettingTaskDetailedSlimResource> GetByReference(string reference);

    //TimeZonePostResponseModel Post([FromBody] StandardSettingTaskCreateResource standardSettingTaskCreateResource);

    TimeZonePostResponseModel Put(long id, StandardSettingTaskUpdateResource standardSettingTaskUpdateResource);

    TimeZonePostResponseModel Put(
        string reference,
        StandardSettingTaskUpdateResource standardSettingTaskUpdateResource);
}