using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Section;
using SurpassApiSdk.DataContracts.TestForm;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.Models;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class TestFormResourceController : ITestFormResourceController
{
    private const string UseReferenceHeader = "useReference";

    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassTestFormUrlFormatter _urlFormatter;

    internal TestFormResourceController(IRestApiClient restApiClient, ISurpassTestFormUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    public PageResponse<TestFormDetailedResource> Get(int testFormId, bool includeItems = false)
    {
        return _restApiClient.CallGet<PageResponse<TestFormDetailedResource>>(
            _urlFormatter.GetForId(testFormId, includeItems));
    }

    public PageResponse<TestFormDetailedResource> Get(string testFormReference, bool includeItems = false)
    {
        return _restApiClient.CallGet<PageResponse<TestFormDetailedResource>>(
            _urlFormatter.GetForRef(testFormReference, includeItems));
    }

    public PageResponse<SectionWithDecisionPointResource> GetSection(int testFormId, int sectionId)
    {
        return _restApiClient.CallGet<PageResponse<SectionWithDecisionPointResource>>(
            _urlFormatter.GetForSectionId(testFormId, sectionId));
    }

    public PageResponse<SectionWithDecisionPointResource> GetSection(string testFormReference, int sectionId)
    {
        return _restApiClient.CallGet<PageResponse<SectionWithDecisionPointResource>>(
            _urlFormatter.GetForSectionId(testFormReference, sectionId),
            new[] { new HttpHeader { Name = UseReferenceHeader, Value = "true" } });
    }

    public PostResponseModel Post(TestFormInputResource testFormInput)
    {
        return _restApiClient.CallPost<TimeZonePostResponseModel, TestFormInputResource>(
            _urlFormatter.Get(),
            testFormInput);
    }
    public PostResponseModel Put(TestFormInputResource testFormInput)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, TestFormInputResource>(
            _urlFormatter.Get(),
            testFormInput);
    }

    public PostResponseModel Put(int id, TestFormInputResource testFormInput, IEnumerable<HttpHeader> headers = null)
    {
        return _restApiClient.CallPut<TimeZonePostResponseModel, TestFormInputResource>(
            _urlFormatter.GetForId(id),
            testFormInput,
            headers);
    }

    public SectionUpdateResponse PutSection(int testFormId, int sectionId, SectionUpdateResource section)
    {
        return _restApiClient.CallPut<SectionUpdateResponse, SectionUpdateResource>(
            _urlFormatter.GetForSectionId(testFormId, sectionId),
            section);
    }

    public SectionUpdateResponse PutSection(string testFormReference, int sectionId, SectionUpdateResource section)
    {
        return _restApiClient.CallPut<SectionUpdateResponse, SectionUpdateResource>(
            _urlFormatter.GetForSectionId(testFormReference, sectionId),
            section,
            new[] { new HttpHeader { Name = UseReferenceHeader, Value = "true" } });
    }
}