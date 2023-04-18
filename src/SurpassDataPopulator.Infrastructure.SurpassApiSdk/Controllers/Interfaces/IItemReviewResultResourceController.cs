using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.ItemReview;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IItemReviewResultResourceController
    {
        TimeZonePageResponse<ItemReviewResultResource> Get(long taskId, string queryString = null);

        TimeZonePageResponse<ItemReviewResultResource> Get(string taskReference, string queryString = null);

        TimeZonePageResponse<ItemReviewResultDetailedResource> GetDetailed(long id);

        TimeZonePostResponseModel Put(long id, ItemReviewResultUpdateResource itemReviewResultUpdateResource);
    }
}
