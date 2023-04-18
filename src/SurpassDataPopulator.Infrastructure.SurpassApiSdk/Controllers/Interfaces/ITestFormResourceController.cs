using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Section;
using SurpassApiSdk.DataContracts.TestForm;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ITestFormResourceController
    {
        PageResponse<TestFormDetailedResource> Get(int testFormId, bool includeItems = false);

        PageResponse<TestFormDetailedResource> Get(string testFormReference, bool includeItems = false);

        PageResponse<SectionWithDecisionPointResource> GetSection(int testFormId, int sectionId);

        PageResponse<SectionWithDecisionPointResource> GetSection(string testFormReference, int sectionId);

        PostResponseModel Post(TestFormInputResource testFormInput);

        PostResponseModel Put(TestFormInputResource testFormInput);

        PostResponseModel Put(int id, TestFormInputResource testFormInput, IEnumerable<HttpHeader> headers = null);

        SectionUpdateResponse PutSection(int testFormId, int sectionId, SectionUpdateResource section);

        SectionUpdateResponse PutSection(string testFormReference, int sectionId, SectionUpdateResource section);
    }
}
