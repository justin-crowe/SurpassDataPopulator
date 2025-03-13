using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.CentreSubjectAssociation;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class CentreSubjectAssociationResourceController : ICentreSubjectAssociationResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal CentreSubjectAssociationResourceController(
        IRestApiClient restApiClient,
        ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all centre to subject association resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all centre to subject association resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<CentreSubjectAssociationResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CentreSubjectAssociationResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    /// <summary>
    /// Get single centre to subject association resource that matches the id.
    /// </summary>
    /// <param name="id">Centre to subject association id</param>
    /// <returns>
    /// Response model that contains centre to subject association details.
    /// </returns>
    public TimeZonePageResponse<CentreSubjectAssociationDetailedResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CentreSubjectAssociationDetailedResource>>(
            _urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Create centre to subject association resource in the database using provided data.
    /// </summary>
    /// <param name="centreSubjectAssociation">Centre to subject association details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Post(CentreSubjectAssociationCreateResource centreSubjectAssociation)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, CentreSubjectAssociationCreateResource>(
            _urlFormatter.Get(),
            centreSubjectAssociation);
    }

    /// <summary>
    /// Update centre to subject association resource in the database using provided data.
    /// </summary>
    /// <param name="id">Centre to subject association id</param>
    /// <param name="centreSubjectAssociation">Centre to subject association details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Put(long id, CentreSubjectAssociationUpdateResource centreSubjectAssociation)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, CentreSubjectAssociationUpdateResource>(
            _urlFormatter.GetForId(id),
            centreSubjectAssociation);
    }

    /// <summary>
    /// Delete centre to subject association resource from the database using provided data.
    /// </summary>
    /// <param name="id">Centre to subject association id</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public TimeZonePostResponseModel Delete(long id)
    {
        return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForId(id));
    }
}