using SurpassApiSdk.DataContracts.ProductToken;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IProductTokenResourceController
{
    TimeZonePageResponse<ProductTokenDetailedResource> Get(
        ProductType productId,
        ProductTabType productTabId);
}