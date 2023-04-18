using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.BasicPage;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class BasicPageResourceController : IBasicPageResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassBasicPageApiUrlFormatter _urlFormatter;

        internal BasicPageResourceController(
            IRestApiClient restApiClient,
            ISurpassBasicPageApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TimeZonePageResponse<BasicPageResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<BasicPageResource>>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="basicPageResource"></param>
        /// <returns></returns>
        public PostResponseModel Post(BasicPageInputResource basicPageResource)
        {
            return _restApiClient.CallPost<TimeZonePostResponseModel, BasicPageInputResource>(
                _urlFormatter.Get(),
                basicPageResource);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="basicPageResource"></param>
        /// <returns></returns>
        public PostResponseModel Put(int id, BasicPageUpdateResource basicPageResource)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, BasicPageUpdateResource>(
                _urlFormatter.GetForId(id),
                basicPageResource);
        }

        /// <summary>
        /// Get assistive media resource that matches the item id/ assistive media id.
        /// </summary>
        /// <param name="id">Item id</param>
        /// <param name="assistiveMediaId">Assistive media id</param>
        /// <returns>
        /// Response model that contains assistive media details.
        /// </returns>
        public TimeZonePageResponse<AssistiveMediaResource> GetAssistiveMedia(int id, int assistiveMediaId)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<AssistiveMediaResource>>(
                _urlFormatter.GetForIdAssistiveId(id, assistiveMediaId));
        }

        /// <summary>
        /// Put assistive media resource that matches the item id/ assistive media id.
        /// </summary>
        /// <param name="id">Item id</param>
        /// <param name="assistiveMediaId">Assistive media id</param>
        /// <param name="resource">Assistive media data</param>
        /// <returns></returns>
        public PostResponseModel PutAssistiveMedia(int id, int assistiveMediaId, AssistiveMediaInputResource resource)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, AssistiveMediaInputResource>(
                _urlFormatter.GetForIdAssistiveId(id, assistiveMediaId),
                resource);
        }
    }
}
