using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Folder;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class FolderResourceController : IFolderResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassApiUrlFormatter _urlFormatter;

    internal FolderResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Get all folder resources that match the query string.
    /// </summary>
    /// <param name="queryString">OData query string of string empty</param>
    /// <returns>
    /// Response model that contains common info like total items count, next and previous pages links, and etc.,
    /// and contains all folder resources that match the filter.
    /// </returns>
    public TimeZonePageResponse<FolderResource> Get(string queryString = null)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<FolderResource>>(
            _urlFormatter.GetForQueryString(queryString));
    }

    /// <summary>
    /// Get single folder resource that matches the id.
    /// </summary>
    /// <param name="id">Folder id</param>
    /// <returns>
    /// Response model that contains folder details.
    /// </returns>
    public TimeZonePageResponse<FolderResource> Get(long id)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<FolderResource>>(_urlFormatter.GetForId(id));
    }

    /// <summary>
    /// Create folder resource in the database using provided data.
    /// </summary>
    /// <param name="folderInput">Folder details</param>
    /// <returns>Response model that contains information about execution result.</returns>
    public PostResponseModel Post(FolderInputResource folderInput)
    {
        return _restApiClient.CallPost<PostResponseModel, FolderInputResource>(_urlFormatter.Get(), folderInput);
    }

    public PostResponseModel Put(int id, FolderUpdateResource folderInput)
    {
        return _restApiClient.CallPut<PostResponseModel, FolderUpdateResource>(
            _urlFormatter.GetForId(id),
            folderInput);
    }
}