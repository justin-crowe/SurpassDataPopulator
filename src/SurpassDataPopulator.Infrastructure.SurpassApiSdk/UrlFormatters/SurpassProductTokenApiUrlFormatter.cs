using System.Globalization;
using SurpassApiSdk.DataContracts.ProductToken;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.UrlFormatters;

internal class SurpassProductTokenApiUrlFormatter : SurpassApiUrlFormatter, ISurpassProductTokenApiUrlFormatter
{
    private const string ProductTypeParameter = "productId={0}";
    private const string ProductTabTypeParameter = "productTabId={0}";

    public SurpassProductTokenApiUrlFormatter(string template)
        : base(template)
    {
    }

    public string GetForTypeWithTab(ProductType productType, ProductTabType productTab)
    {
        var productIdParameter = string.Format(CultureInfo.InvariantCulture, ProductTypeParameter, (int)productType);
        var productTabIdParameter = string.Format(CultureInfo.InvariantCulture, ProductTabTypeParameter, (int)productTab);
        var parameters = string.Join("&", productIdParameter, productTabIdParameter);

        return string.Join("?", Template, parameters);
    }
}