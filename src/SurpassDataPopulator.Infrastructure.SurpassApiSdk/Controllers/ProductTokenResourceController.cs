using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.ProductToken;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class ProductTokenResourceController : IProductTokenResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassProductTokenApiUrlFormatter _urlFormatter;

    internal ProductTokenResourceController(
        IRestApiClient restApiClient,
        ISurpassProductTokenApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    public TimeZonePageResponse<ProductTokenDetailedResource> Get(
        ProductType productId,
        ProductTabType productTabId)
    {
        return
            _restApiClient.CallGet<TimeZonePageResponse<ProductTokenDetailedResource>>(
                _urlFormatter.GetForTypeWithTab(productId, productTabId));
    }
}