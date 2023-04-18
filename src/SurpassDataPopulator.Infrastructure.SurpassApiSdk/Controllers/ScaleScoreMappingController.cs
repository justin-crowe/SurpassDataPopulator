using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.ScaleScoreMapping;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class ScaleScoreMappingController : IScaleScoreMappingController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassResultApiUrlFormatter _urlFormatter;

        internal ScaleScoreMappingController(IRestApiClient restApiClient, ISurpassResultApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get single result resource that matches the id.
        /// </summary>
        /// <param name="id">Result id</param>
        /// <returns>
        /// Response model that contains scale score details.
        /// </returns>
        public TimeZonePageResponse<ScaleScoreMappingDetailedResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<ScaleScoreMappingDetailedResource>>(
                _urlFormatter.GetForId(id));
        }
    }
}
