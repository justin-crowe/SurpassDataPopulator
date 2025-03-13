using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.StandardSetting;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IStandardSettingResultResourceController
{
    TimeZonePageResponse<StandardSettingResultResource> Get(long taskId, string queryString = null);

    TimeZonePageResponse<StandardSettingResultResource> Get(string taskReference, string queryString = null);

    TimeZonePageResponse<StandardSettingResultDetailedResource> GetDetailed(long id);

    TimeZonePostResponseModel Put(long id, StandardSettingResultUpdateResource standardSettingResultUpdateResource);
}