using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.MediaGroup;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class MediaGroupResourceController : IMediaGroupResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal MediaGroupResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Create media group resource in the database using provided data.
        /// </summary>
        /// <param name="mediaGroupInput">MediaGroup details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Post(MediaGroupInputResource mediaGroupInput)
        {
            return _restApiClient.CallPost<PostResponseModel, MediaGroupInputResource>(
                _urlFormatter.Get(),
                mediaGroupInput);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TimeZonePageResponse<MediaGroupDetailedResource> GetById(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<MediaGroupDetailedResource>>(_urlFormatter.GetForId(id));
        }

        public PostResponseModel Put(int id, MediaGroupUpdateResource mediaGroup)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, MediaGroupUpdateResource>(
                _urlFormatter.GetForId(id),
                mediaGroup);
        }
    }
}
