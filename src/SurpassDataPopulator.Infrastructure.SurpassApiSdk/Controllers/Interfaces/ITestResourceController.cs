using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Test;
using SurpassApiSdk.DataContracts.TestForm;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ITestResourceController
    {
        PostResponseModel Post(TestInputResource testInput);

        TimeZonePageResponse<TestLinkedResource> Get(string queryString = null);

        TimeZonePageResponse<TestDetailedResource> Get(long id);

        TimeZonePageResponse<TestFormLinkedResource> GetTestFormsByTestId(
            int id,
            string queryString = null,
            bool scheduledTestFormsOnly = false);

        TimeZonePageResponse<TestFormLinkedResource> GetTestFormsByTestRef(
            string reference,
            string queryString = null,
            bool scheduledTestFormsOnly = false);
    }
}
