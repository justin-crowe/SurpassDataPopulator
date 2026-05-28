using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagCollection;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ITagCollectionGroupResourceController
{
    /// <summary>
    /// Get all <see cref="TagCollectionGroupLinkedResource"/> resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all tag categories that match the filter.
    /// </returns>
    TimeZonePageResponse<TagCollectionGroupLinkedResource> Get(string queryString = null);

    /// <summary>
    /// Get single <see cref="TagCollectionGroupResource"/> that matches the id.
    /// </summary>
    /// <param name="id"><see cref="TagCollectionGroupResource"/> identifier</param>
    /// <returns>
    /// Response model that contains tag category details.
    /// </returns>
    TimeZonePageResponse<TagCollectionGroupDetailedResource> Get(long id);

    /// <summary>
    /// Create <see cref="TagCollectionGroupResource"/> resource in the database using provided data.
    /// </summary>
    /// <param name="input"><see cref="TagCollectionGroupLinkedResource"/></param>
    /// <returns>Response model that contains information about execution result.</returns>
    PostResponseModel Post(TagCollectionGroupInputResource input);

    /// <summary>
    /// Delete <see cref="TagCollectionGroupResource"/> resource in the database using provided data.
    /// </summary>
    /// <param name="id"><see cref="TagCollectionGroupResource"/> identifier</param>
    /// <returns>Response model that contains information about execution result.</returns>
    PostResponseModel Delete(long id);
}