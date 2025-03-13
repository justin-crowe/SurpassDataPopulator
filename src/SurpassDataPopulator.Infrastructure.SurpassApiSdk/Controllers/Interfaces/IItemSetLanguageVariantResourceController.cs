using SurpassApiSdk.DataContracts.Item.LanguageVariants;
using SurpassApiSdk.DataContracts.ItemSet.LanguageVariants;
using SurpassApiSdk.DataContracts.Response;

namespace SurpassApiSdk.Controllers.Interfaces;

public interface IItemSetLanguageVariantResourceController
{
    TimeZonePageResponse<LvItemSetResource> Get(int id, string languageCode);

    PostLvResponseModel Post(int id, LvItemSetInputResource lvItemSetInput);

    PostLvResponseModel Put(int id, string languageCode, LvItemSetUpdateResource lvItemSetUpdate);

    TimeZonePostResponseModel Delete(int id, string languageCode);
}