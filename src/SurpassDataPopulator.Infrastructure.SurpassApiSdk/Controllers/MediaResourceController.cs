using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Media;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class MediaResourceController : IMediaResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal MediaResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Create media resource in the database using provided data.
        /// </summary>
        /// <param name="mediaInput">Media details.</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Post(MediaInputResource mediaInput)
        {
            return _restApiClient.CallPost<PostResponseModel, MediaInputResource>(_urlFormatter.Get(), mediaInput);
        }

        /// <summary>
        /// Gets media resource from the database by id.
        /// </summary>
        /// <param name="id">Media's id.</param>
        /// <returns>Media resource's model.</returns>
        public TimeZonePageResponse<MediaDetailedResource> GetById(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<MediaDetailedResource>>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Gets media resource's content from the database by id.
        /// </summary>
        /// <param name="id">Media's id.</param>
        /// <returns>Media resource's content as a stream.</returns>
        public Stream GetDataById(int id)
        {
            return _restApiClient.CallGetStream(_urlFormatter.GetForDataById(id));
        }
    }
}
