using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagCategory;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ITagCategoryResourceController
    {
        /// <summary>
        /// Get all tag categories resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all tag categories that match the filter.
        /// </returns>
        TimeZonePageResponse<TagCategoryResource> Get(string queryString = null);

        /// <summary>
        /// Get single tag group category that matches the id.
        /// </summary>
        /// <param name="id">TagGroup id</param>
        /// <returns>
        /// Response model that contains tag category details.
        /// </returns>
        TimeZonePageResponse<TagCategoryDetailedResource> Get(long id);

        /// <summary>
        /// Create category resource in the database using provided data.
        /// </summary>
        /// <param name="tagCategoryInput">Category details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        PostResponseModel Post(TagCategoryInputResource tagCategoryInput);

        /// <summary>
        /// Update category resource in the database using provided data.
        /// </summary>
        /// <param name="id">Category id</param>
        /// <param name="tagCategoryInput">Category details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        PostResponseModel Put(int id, TagCategoryUpdateResource tagCategoryInput);

        /// <summary>
        /// Delete category resource in the database using provided data.
        /// </summary>
        /// <param name="id">Category id</param>
        /// <returns>Response model that contains information about execution result.</returns>
        PostResponseModel Delete(int id);
    }
}
