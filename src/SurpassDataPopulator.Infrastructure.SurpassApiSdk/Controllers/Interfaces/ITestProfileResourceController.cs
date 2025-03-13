using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TestProfile;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface ITestProfileResourceController
{
    TimeZonePageResponse<TestProfileDetailedResource> Get(int id);

    PostResponseModel Post(TestProfileInputResource testProfileInput);
}