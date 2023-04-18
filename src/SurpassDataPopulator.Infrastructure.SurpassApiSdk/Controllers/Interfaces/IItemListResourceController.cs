using SurpassApiSdk.DataContracts.ItemList;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IItemListResourceController
    {
        TimeZonePageResponse<ItemListDetailResource> Get(int id);

        TimeZonePageResponse<ItemListDetailResource> GetByReference(string reference);

        TimeZonePageResponse<ItemListResource> Get(string queryString);

        TimeZonePostResponseModel Delete(int id, bool permanent = false);

        TimeZonePostResponseModel Delete(string reference, bool permanent = false);

        TimeZonePostResponseModel Post(ItemListCreateResource itemListCreateResource);

        TimeZonePostResponseModel Put(int id, ItemListUpdateResource itemUpdateListUpdate);
    }
}
