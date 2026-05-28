using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.WorkflowStatus;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IWorkflowStatusResourceController
{
    TimeZonePageResponse<WorkflowStatusResource> Get();
}