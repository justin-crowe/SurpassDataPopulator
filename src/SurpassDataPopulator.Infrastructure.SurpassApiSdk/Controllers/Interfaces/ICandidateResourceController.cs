using SurpassApiSdk.DataContracts.Candidate;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ICandidateResourceController
{
    TimeZonePageResponse<CandidateDetailedResource> Get(int id);

    TimeZonePageResponse<CandidateResource> Get(string queryString = null);

    TimeZonePageResponse<CandidateDetailedResource> GetByReference(string reference);

    TimeZonePostResponseModel Post(CandidateCreateResource candidate);

    TimeZonePostResponseModel Put(
        string reference,
        CandidateUpdateResource candidate,
        IEnumerable<HttpHeader> headers = null);

    TimeZonePostResponseModel Put(
        int id,
        CandidateUpdateResource candidate,
        IEnumerable<HttpHeader> headers = null);
}