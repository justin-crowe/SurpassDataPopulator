using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagValue;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class TagValueResourceController : ITagValueResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal TagValueResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Get all tagValue resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all centre resources that match the filter.
        /// </returns>
        public TimeZonePageResponse<TagValueManyResource> Get(string queryString = null)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TagValueManyResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        /// <summary>
        /// Get single tagValue resource that matches the id.
        /// </summary>
        /// <param name="id">Folder id</param>
        /// <returns>
        /// Response model that contains tagValue details.
        /// </returns>
        public TimeZonePageResponse<TagValueResource> Get(long id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<TagValueResource>>(_urlFormatter.GetForId(id));
        }

        /// <summary>
        /// Create tagValue resource in the database using provided data.
        /// </summary>
        /// <param name="tagValueInput">TagValue details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Post(TagValueInputResource tagValueInput)
        {
            return _restApiClient.CallPost<PostResponseModel, TagValueInputResource>(
                _urlFormatter.Get(),
                tagValueInput);
        }

        /// <summary>
        /// Update tagValue resource in the database using provided data.
        /// </summary>
        /// <param name="id">Tag id</param>
        /// <param name="tagValueInput">TagValue details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public PostResponseModel Put(int id, TagValueUpdateResource tagValueInput)
        {
            return _restApiClient.CallPut<PostResponseModel, TagValueUpdateResource>(
                _urlFormatter.GetForId(id),
                tagValueInput);
        }
    }
}
