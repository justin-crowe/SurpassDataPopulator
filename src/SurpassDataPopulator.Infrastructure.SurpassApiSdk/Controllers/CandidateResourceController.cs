using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Candidate;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class CandidateResourceController : ICandidateResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal CandidateResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all candidate resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all candidate resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<CandidateResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CandidateResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    /// <summary>
    /// Get single candidate resource that matches the id.
    /// </summary>
    /// <param name="id">Candidate id</param>
    /// <returns>
    /// Response model that contains candidate details.
    /// </returns>
    public TimeZonePageResponse<CandidateDetailedResource> Get(int id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CandidateDetailedResource>>(_urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Get single candidate resource that matches the reference.
    /// </summary>
    /// <param name="reference">Candidate reference</param>
    /// <returns>
    /// Response model that contains candidate details.
    /// </returns>
    public TimeZonePageResponse<CandidateDetailedResource> GetByReference(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CandidateDetailedResource>>(
            _urlFormatter.GetForReference(reference));
    }

    /// <summary>
    /// Create candidate resource in the database using provided data.
    /// </summary>
    /// <param name="candidate">Candidate details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Post(CandidateCreateResource candidate)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, CandidateCreateResource>(
            _urlFormatter.Get(),
            candidate);
    }

    /// <summary>
    /// Update candidate resource in the database using provided data.
    /// </summary>
    /// <param name="id">Candidate id</param>
    /// <param name="candidate">Candidate details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(
        int id,
        CandidateUpdateResource candidate,
        IEnumerable<HttpHeader> headers = null)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, CandidateUpdateResource>(
            _urlFormatter.GetForId(id),
            candidate,
            headers);
    }

    /// <summary>
    /// Update candidate resource in the database using provided data.
    /// </summary>
    /// <param name="reference">Candidate reference</param>
    /// <param name="candidate">Candidate details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(
        string reference,
        CandidateUpdateResource candidate,
        IEnumerable<HttpHeader> headers = null)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, CandidateUpdateResource>(
            _urlFormatter.GetForReference(reference),
            candidate,
            headers);
    }
}