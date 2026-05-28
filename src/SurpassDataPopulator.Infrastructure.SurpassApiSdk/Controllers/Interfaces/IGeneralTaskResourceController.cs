using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.General;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IGeneralTaskResourceController
{
    TimeZonePageResponse<GeneralTaskDetailedSlimResource> Get(long id);

    TimeZonePageResponse<GeneralTaskDetailedExtendedResource> GetDetailed(long id);

    TimeZonePageResponse<GeneralTaskDetailedSlimResource> GetByReference(string reference);

    TimeZonePageResponse<GeneralTaskDetailedExtendedResource> GetByReferenceDetailed(string reference);

    TimeZonePostResponseModel Post(GeneralTaskCreateResource generalTaskCreateResource);

    TimeZonePostResponseModel Put(
        long id,
        GeneralTaskUpdateResource generalTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null);

    TimeZonePostResponseModel Put(
        string reference,
        GeneralTaskUpdateResource generalTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null);
}