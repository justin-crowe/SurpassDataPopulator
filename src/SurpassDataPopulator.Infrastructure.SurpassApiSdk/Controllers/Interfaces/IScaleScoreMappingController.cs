using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.ScaleScoreMapping;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IScaleScoreMappingController
{
    TimeZonePageResponse<ScaleScoreMappingDetailedResource> Get(int id);
}