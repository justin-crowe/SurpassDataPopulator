using SurpassApiSdk.DataContracts.ItemSet;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IItemSetResourceController
{
    TimeZonePageResponse<ItemSetResource> Get(long id);

    TimeZonePageResponse<ItemSetResource> Get(string queryString = null);

    PostResponseModel Post(ItemSetInputResource itemSet);

    PostResponseModel Put(long id, ItemSetUpdateResource itemSet);

    ItemDeleteTimeZonePostResponseModel Delete(long id);
}