using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ICentreResourceController
    {
        TimeZonePostResponseModel Delete(string reference);

        TimeZonePostResponseModel Delete(int id);

        TimeZonePageResponse<CentreDetailedResource> Get(int id);

        TimeZonePageResponse<CentreLinkedResource> Get(string queryString = null);

        TimeZonePageResponse<CentreDetailedResource> GetByReference(string reference);

        TimeZonePostResponseModel Post(CentreCreateResource centreResource);

        TimeZonePostResponseModel Put(
            string reference,
            CentreUpdateResource centreResource,
            IEnumerable<HttpHeader> headers = null);

        TimeZonePostResponseModel Put(
            int id,
            CentreUpdateResource centreResource,
            IEnumerable<HttpHeader> headers = null);
    }
}
