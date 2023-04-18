using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.WorkflowStatus;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class WorkflowStatusResourceController : IWorkflowStatusResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal WorkflowStatusResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all available workflow statuses.
        /// </summary>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all workflow statuses.
        /// </returns>
        public TimeZonePageResponse<WorkflowStatusResource> Get()
        {
            return _restApiClient.CallGet<TimeZonePageResponse<WorkflowStatusResource>>(_urlFormatter.Get());
        }
    }
}
