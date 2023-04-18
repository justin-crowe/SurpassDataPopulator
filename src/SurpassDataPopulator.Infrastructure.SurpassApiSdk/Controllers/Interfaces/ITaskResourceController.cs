using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.Base;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ITaskResourceController
    {
        TimeZonePageResponse<TaskLinkedResource> Get(string queryString = null);
    }
}
