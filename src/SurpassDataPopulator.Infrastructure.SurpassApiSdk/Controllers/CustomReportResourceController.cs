using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.CustomReports;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class CustomReportResourceController : ICustomReportResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _apiUrlFormatter;

    internal CustomReportResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter apiUrlFormatter)
    {
        _restApiClient = restApiClient;
        _apiUrlFormatter = apiUrlFormatter;
    }

    public TimeZonePageResponse<CustomReportLinkedResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CustomReportLinkedResource>>(
            _apiUrlFormatter.GetForQueryString(queryString));
    }

    public TimeZonePageResponse<CustomReportDetailedResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CustomReportDetailedResource>>(
            _apiUrlFormatter.GetForId(id));
    }

    public TimeZonePageResponse<CustomReportDetailedResource> GetByReference(string reference)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<CustomReportDetailedResource>>(
            _apiUrlFormatter.GetForReference(reference));
    }

    public TimeZonePostResponseModel Delete(string reference)
    {
        return _restApiClient.CallDelete<TimeZonePostResponseModel>(_apiUrlFormatter.GetForReference(reference));
    }

    public TimeZonePostResponseModel Delete(long id)
    {
        return _restApiClient.CallDelete<TimeZonePostResponseModel>(_apiUrlFormatter.GetForId(id));
    }
}