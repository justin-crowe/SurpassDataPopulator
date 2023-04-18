using SurpassApiSdk.DataContracts.Country;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ICountryResourceController
    {
        /// <summary>
        /// Get all country resources that match the query string.
        /// </summary>
        /// <param name="queryString">OData query string</param>
        /// <returns>
        /// Response model that contains common info like total items count, next and previous pages links, and etc.,
        /// and contains all countries resources that match the filter.
        /// </returns>
        TimeZonePageResponse<CountryLinkedResource> Get(string queryString = null);

        /// <summary>
        /// Get single country resource that matches the id.
        /// </summary>
        /// <param name="id">Country id</param>
        /// <returns>Response model that contains country details.</returns>
        TimeZonePageResponse<CountryDetailedResource> Get(int id);
    }
}
