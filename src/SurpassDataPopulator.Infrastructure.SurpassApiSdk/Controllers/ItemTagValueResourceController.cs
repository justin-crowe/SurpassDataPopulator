using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.ItemTagValue;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ItemTagValueResourceController : IItemTagValueResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal ItemTagValueResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Create itemTagValue resource in the database using provided data.
    /// </summary>
    /// <param name="itemTagValueInput">ItemTagValue details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public PostResponseModel Post(ItemTagValueInputResource itemTagValueInput)
    {
        return _restApiClient.CallPost<PostResponseModel, ItemTagValueInputResource>(
            _urlFormatter.Get(),
            itemTagValueInput);
    }

    public TimeZonePageResponse<SubjectTagValueItemResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<SubjectTagValueItemResource>>(
            _urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Delete itemTagValue resource from the database using provided data.
    /// </summary>
    /// <param name="itemTagValueInput">ItemTagValue details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public PostResponseModel Delete(ItemTagValueInputResource itemTagValueInput)
    {
        return _restApiClient.CallDelete<PostResponseModel, ItemTagValueInputResource>(
            _urlFormatter.Get(),
            itemTagValueInput);
    }
}