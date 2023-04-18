using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.ItemList;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class ItemListResourceController : IItemListResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassItemListApiUrlFormatter _urlFormatter;

        internal ItemListResourceController(IRestApiClient restApiClient, ISurpassItemListApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        public TimeZonePageResponse<ItemListDetailResource> Get(int id)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<ItemListDetailResource>>(_urlFormatter.GetForId(id));
        }

        public TimeZonePageResponse<ItemListDetailResource> GetByReference(string reference)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<ItemListDetailResource>>(
                _urlFormatter.GetForReference(reference));
        }

        public TimeZonePageResponse<ItemListResource> Get(string queryString)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<ItemListResource>>(
                _urlFormatter.GetForQueryString(queryString));
        }

        public TimeZonePostResponseModel Delete(int id, bool permanent = false)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(_urlFormatter.GetForId(id, permanent));
        }

        public TimeZonePostResponseModel Delete(string reference, bool permanent = false)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(
                _urlFormatter.GetForReference(reference, permanent));
        }

        public TimeZonePostResponseModel Post(ItemListCreateResource itemListCreateResource)
        {
            return _restApiClient.CallPost<TimeZonePostResponseModel, ItemListCreateResource>(
                _urlFormatter.Get(),
                itemListCreateResource);
        }

        public TimeZonePostResponseModel Put(int id, ItemListUpdateResource itemUpdateListUpdate)
        {
            return _restApiClient.CallPut<TimeZonePostResponseModel, ItemListUpdateResource>(
                _urlFormatter.GetForId(id),
                itemUpdateListUpdate);
        }
    }
}
