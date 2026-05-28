using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Task.ItemReview;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IItemReviewTaskResourceController
{
    TimeZonePageResponse<ItemReviewTaskDetailedSlimResource> Get(long id);

    TimeZonePageResponse<ItemReviewTaskDetailedExtendedResource> GetDetailed(long id);

    TimeZonePageResponse<ItemReviewTaskDetailedSlimResource> GetByReference(string reference);

    TimeZonePageResponse<ItemReviewTaskDetailedExtendedResource> GetByReferenceDetailed(string reference);

    TimeZonePostResponseModel Post(ItemReviewTaskCreateResource itemReviewTaskCreateResource);

    TimeZonePostResponseModel Put(
        long id,
        ItemReviewTaskUpdateResource itemReviewTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null);

    TimeZonePostResponseModel Put(
        string reference,
        ItemReviewTaskUpdateResource itemReviewTaskUpdateResource,
        IEnumerable<HttpHeader> headers = null);
}