using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.TagCollection;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class TagCollectionGroupResourceController : ITagCollectionGroupResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal TagCollectionGroupResourceController(
        IRestApiClient restApiClient,
        ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    public TimeZonePageResponse<TagCollectionGroupLinkedResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<TagCollectionGroupLinkedResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    public TimeZonePageResponse<TagCollectionGroupDetailedResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<TagCollectionGroupDetailedResource>>(
            _urlFormatter.GetForId(id));
    }

    public PostResponseModel Post(TagCollectionGroupInputResource input)
    {
        return _restApiClient.CallPost<PostResponseModel, TagCollectionGroupInputResource>(
            _urlFormatter.Get(),
            input);
    }

    public PostResponseModel Delete(long id)
    {
        return _restApiClient.CallDelete<PostResponseModel>(_urlFormatter.GetForId(id));
    }
}