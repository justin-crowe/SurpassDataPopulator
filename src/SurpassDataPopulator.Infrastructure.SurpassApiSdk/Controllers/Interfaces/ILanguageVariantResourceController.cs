using SurpassApiSdk.DataContracts.Item.LanguageVariants;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ILanguageVariantResourceController
    {
        TimeZonePageResponse<LvItemResource> Get(int itemId, string languageCode);

        PostLvResponseModel Post(int itemId, LvItemInputResource itemLvInput);

        PostLvResponseModel Put(int itemId, string languageCode, LvItemUpdateResource itemLvUpdate);

        TimeZonePostResponseModel Delete(int itemId, string languageCode);
    }
}
