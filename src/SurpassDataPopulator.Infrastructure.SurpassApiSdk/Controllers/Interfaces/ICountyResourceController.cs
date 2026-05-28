using SurpassApiSdk.DataContracts.County;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ICountyResourceController
{
    /// <summary>
    /// Get all counties resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all counties resources that match the filter.
    /// </returns>
    TimeZonePageResponse<CountyLinkedResource> Get(string queryString = null);

    /// <summary>
    /// Get single county resource that matches the id.
    /// </summary>
    /// <param name="id">County id</param>
    /// <returns>Response model that contains county details.</returns>
    TimeZonePageResponse<CountyLinkedResource> Get(int id);
}