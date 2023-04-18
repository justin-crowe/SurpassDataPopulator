using SurpassApiSdk.DataContracts.ProductToken;

namespace SurpassApiSdk.UrlFormatters.Interfaces
{
    internal interface ISurpassProductTokenApiUrlFormatter
    {
        string GetForTypeWithTab(ProductType productType, ProductTabType productTab);
    }
}
