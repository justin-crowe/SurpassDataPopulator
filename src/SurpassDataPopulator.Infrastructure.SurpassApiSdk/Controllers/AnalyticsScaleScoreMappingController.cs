using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.AnalyticsScaleScoreMappingResult;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class AnalyticsScaleScoreMappingController : IAnalyticsScaleScoreMappingController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassResultApiUrlFormatter _urlFormatter;

        internal AnalyticsScaleScoreMappingController(
            IRestApiClient restApiClient,
            ISurpassResultApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        public TimeZonePageResponse<AnalyticsScaleScoreMappingDetailedResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<AnalyticsScaleScoreMappingDetailedResource>>(
                _urlFormatter.GetForId(id));
        }
    }
}
