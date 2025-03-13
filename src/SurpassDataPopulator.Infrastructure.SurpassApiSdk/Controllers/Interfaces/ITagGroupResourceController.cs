using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagGroup;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ITagGroupResourceController
{
    /// <summary>
    /// Get all tag group resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all tag group resources that match the filter.
    /// </returns>
    TimeZonePageResponse<TagGroupResource> Get(string queryString = null);

    /// <summary>
    /// Get single tag group resource that matches the id.
    /// </summary>
    /// <param name="id">TagGroup id</param>
    /// <returns>
    /// Response model that contains tag group details.
    /// </returns>
    TimeZonePageResponse<TagGroupDetailedResource> Get(long id);

    /// <summary>
    /// Create tagGroup resource in the database using provided data.
    /// </summary>
    /// <param name="tagGroupInput">TagGroup details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    PostResponseModel Post(TagGroupInputResource tagGroupInput);

    /// <summary>
    /// Update tagGroup resource in the database using provided data.
    /// </summary>
    /// <param name="id">Tag id</param>
    /// <param name="tagGroupInput">TagGroup details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    PostResponseModel Put(int id, TagGroupUpdateResource tagGroupInput);
}