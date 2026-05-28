using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ISubjectResourceController
{
    TimeZonePostResponseModel Delete(string reference);

    TimeZonePostResponseModel Delete(long id);

    TimeZonePageResponse<SubjectDetailedResource> Get(long id);

    TimeZonePageResponse<SubjectLinkedResource> Get(string queryString = null);

    TimeZonePageResponse<SubjectDetailedResource> GetByReference(string reference);

    TimeZonePostResponseModel Post(SubjectCreateResource subjectResource);

    TimeZonePostResponseModel Put(
        string reference,
        SubjectUpdateResource subjectResource,
        IEnumerable<HttpHeader> headers = null);

    TimeZonePostResponseModel Put(
        long id,
        SubjectUpdateResource subjectResource,
        IEnumerable<HttpHeader> headers = null);
}