using SurpassApiSdk.DataContracts.BasicPage;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IBasicPageResourceController
{
    TimeZonePageResponse<BasicPageResource> Get(int id);

    PostResponseModel Post(BasicPageInputResource basicPageResource);

    PostResponseModel Put(int id, BasicPageUpdateResource basicPageResource);

    TimeZonePageResponse<AssistiveMediaResource> GetAssistiveMedia(int id, int assistiveMediaId);

    PostResponseModel PutAssistiveMedia(int id, int assistiveMediaId, AssistiveMediaInputResource resource);
}