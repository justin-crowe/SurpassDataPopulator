using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.RescoringRules;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class RescoringRuleResourceController : IRescoringRuleResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal RescoringRuleResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    public TimeZonePageResponse<RescoringRuleResource> Get(string queryString = null)
    {
        return
            _restApiClient.CallGet<TimeZonePageResponse<RescoringRuleResource>>(
                _urlFormatter.GetForQueryString(queryString));
    }

    public TimeZonePageResponse<RescoringRuleDetailedResource> Get(long id)
    {
        if (_restApiClient.MediaType == SurpassApiMediaType.Json)
        {
            var auxilaryResult =
                _restApiClient.CallGet<TimeZonePageResponse<RescoringRuleDetailedResourceJsonAuxilary>>(
                    _urlFormatter.GetForId(id));

            var result = new TimeZonePageResponse<RescoringRuleDetailedResource>();
            result.Copy(auxilaryResult);

            var detailedResources = new List<RescoringRuleDetailedResource>();

            foreach (var detailedAuxilary in auxilaryResult.Response)
            {
                var detailedResource = detailedAuxilary.ToRescoringRuleDetailedResource();

                detailedResources.Add(detailedResource);
            }

            result.Response = detailedResources;

            return result;
        }

        return
            _restApiClient.CallGet<TimeZonePageResponse<RescoringRuleDetailedResource>>(_urlFormatter.GetForId(id));
    }
}