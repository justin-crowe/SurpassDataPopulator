using SurpassApiSdk.DataContracts.RescoringRules;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IRescoringRuleResourceController
{
    TimeZonePageResponse<RescoringRuleResource> Get(string queryString = null);

    TimeZonePageResponse<RescoringRuleDetailedResource> Get(long id);
}