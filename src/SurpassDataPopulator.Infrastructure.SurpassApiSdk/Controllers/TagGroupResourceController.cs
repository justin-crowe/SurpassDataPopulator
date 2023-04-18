using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class TagGroupResourceController : ITagGroupResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal TagGroupResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all tag group resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all tag group resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<TagGroupResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TagGroupResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single tag group resource that matches the id.
        /// </summary>
        /// <param name="id">TagGroup id</param>
        /// <returns>
        /// Response model that contains tag group details.
        /// </returns>
        public TimeZonePageResponse<TagGroupDetailedResource> Get(long id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TagGroupDetailedResource>>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Create tagGroup resource in the database using provided data.
        /// </summary>
        /// <param name="tagGroupInput">TagGroup details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Post(TagGroupInputResource tagGroupInput)
        {
            return _restApiClient.CallPost<PostResponseModel, TagGroupInputResource>(
                _urlFormatter.Get(),
                tagGroupInput);
        }

        /// <summary>
        /// Update tagGroup resource in the database using provided data.
        /// </summary>
        /// <param name="id">Tag id</param>
        /// <param name="tagGroupInput">TagGroup details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Put(int id, TagGroupUpdateResource tagGroupInput)
        {
            return _restApiClient.CallPut<PostResponseModel, TagGroupUpdateResource>(
                _urlFormatter.GetForId(id),
                tagGroupInput);
        }
    }
}
