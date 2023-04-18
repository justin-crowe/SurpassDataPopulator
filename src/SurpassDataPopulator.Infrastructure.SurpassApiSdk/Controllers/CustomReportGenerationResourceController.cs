using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.CustomReports;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class CustomReportGenerationResourceController : ICustomReportGenerationResourceController
    {
        private readonly IRestApiClient _restApiClient;

        private readonly ISurpassCustomReportApiUrlFormatter _apiUrlFormatter;

        internal CustomReportGenerationResourceController(
            IRestApiClient restApiClient,
            ISurpassCustomReportApiUrlFormatter apiUrlFormatter)
        {
            _restApiClient = restApiClient;
            _apiUrlFormatter = apiUrlFormatter;
        }

        public CustomReportGenerateFilePostResponseModel GenerateFile(CustomReportGenerationInputResource resource)
        {
            return _restApiClient
                .CallPost<CustomReportGenerateFilePostResponseModel, CustomReportGenerationInputResource>(
                    _apiUrlFormatter.GetForFileGeneration(),
                    resource);
        }
    }
}
