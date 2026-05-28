using SurpassApiSdk.DataContracts.Folder;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IFolderResourceController
{
    TimeZonePageResponse<FolderResource> Get(long id);

    TimeZonePageResponse<FolderResource> Get(string queryString = null);

    PostResponseModel Post(FolderInputResource folderInput);

    PostResponseModel Put(int id, FolderUpdateResource folderInput);
}