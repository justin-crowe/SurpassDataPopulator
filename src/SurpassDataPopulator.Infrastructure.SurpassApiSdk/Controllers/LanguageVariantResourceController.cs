using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Item.LanguageVariants;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers;

public class LanguageVariantResourceController : ILanguageVariantResourceController
{
    private readonly IRestApiClient _restApiClient;
    private readonly ISurpassLanguageVariantApiUrlFormatter _urlFormatter;

    internal LanguageVariantResourceController(IRestApiClient restApiClient, ISurpassLanguageVariantApiUrlFormatter urlFormatter)
    {
        _restApiClient = restApiClient;
        _urlFormatter = urlFormatter;
    }

    /// <summary>
    /// Returns a detailed response for Language Variant of item
    /// </summary>
    /// <param name="itemId">Parent item id</param>
    /// <param name="languageCode">Language code of Language Variant item</param>
    /// <returns>Language Variant resource</returns>
    public TimeZonePageResponse<LvItemResource> Get(int itemId, string languageCode)
    {
        return _restApiClient.CallGet<TimeZonePageResponse<LvItemResource>>(_urlFormatter.GetForIdAndCode(itemId, languageCode));
    }

    /// <summary>
    /// Allows creation of language variants
    /// </summary>
    /// <param name="itemId">Parent item id</param>
    /// <param name="itemLvInput">Language Variant item body</param>
    /// <returns>Short info about created Language Variant item</returns>
    public PostLvResponseModel Post(int itemId, LvItemInputResource itemLvInput)
    {
        return _restApiClient.CallPost<PostLvResponseModel, LvItemInputResource>(
            _urlFormatter.GetForParentId(itemId),
            itemLvInput);
    }

    /// <summary>
    /// Allows updating of language variants
    /// </summary>
    /// <param name="itemId">Parent item id</param>
    /// <param name="languageCode">Language code of Language Variant item</param>
    /// <param name="itemLvUpdate">Language Variant item body</param>
    /// <returns>Short info about updated Language Variant item</returns>
    public PostLvResponseModel Put(int itemId, string languageCode, LvItemUpdateResource itemLvUpdate)
    {
        return _restApiClient.CallPut<PostLvResponseModel, LvItemUpdateResource>(
            _urlFormatter.GetForIdAndCode(itemId, languageCode),
            itemLvUpdate);
    }

    /// <summary>
    /// Allows deletion of item language variants
    /// </summary>
    /// <param name="itemId">Parent item id</param>
    /// <param name="languageCode">Language code of Language Variant item</param>
    /// <returns>TimeZonePostResponseModel</returns>
    public TimeZonePostResponseModel Delete(int itemId, string languageCode)
    {
        return _restApiClient.CallDelete<TimeZonePostResponseModel>(
            _urlFormatter.GetForIdAndCode(itemId, languageCode));
    }
}