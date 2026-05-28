using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagCategory;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class TagCategoryResourceController : ITagCategoryResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal TagCategoryResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    public TimeZonePageResponse<TagCategoryResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<TagCategoryResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    public TimeZonePageResponse<TagCategoryDetailedResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<TagCategoryDetailedResource>>(
            _urlFormatter.GetForId(id));
    }

    public PostResponseModel Post(TagCategoryInputResource tagCategoryInput)
    {
        return _restApiClient.CallPost<PostResponseModel, TagCategoryInputResource>(
            _urlFormatter.Get(),
            tagCategoryInput);
    }

    public PostResponseModel Put(int id, TagCategoryUpdateResource tagCategoryInput)
    {
        return _restApiClient.CallPut<PostResponseModel, TagCategoryUpdateResource>(
            _urlFormatter.GetForId(id),
            tagCategoryInput);
    }

    public PostResponseModel Delete(int id)
    {
        return _restApiClient.CallDelete<PostResponseModel>(_urlFormatter.GetForId(id));
    }
}