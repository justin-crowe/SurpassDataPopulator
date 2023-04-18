using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IItemResourceController
    {
        TimeZonePageResponse<ItemLinkedResource> Get(string queryString = null, bool includeDeleted = false);

        TimeZonePageResponse<ItemResource> Get(int id);

        TimeZonePageResponse<AssistiveMediaResource> GetAssistiveMedia(int id, int assistiveMediaId);

        PostResponseModel Post(ItemInputResource itemResource);

        PostResponseModel Put(int id, ItemUpdateResource itemResource);

        PostResponseModel PutAssistiveMedia(int id, int assistiveMediaId, AssistiveMediaInputResource resource);

        ItemDeleteTimeZonePostResponseModel Delete(int id);
    }
}
