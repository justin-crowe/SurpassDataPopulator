using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Item.LanguageVariants;
using SurpassApiSdk.DataContracts.ItemSet.LanguageVariants;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class ItemSetLanguageVariantResourceController : IItemSetLanguageVariantResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassLanguageVariantApiUrlFormatter _urlFormatter;

        internal ItemSetLanguageVariantResourceController(IRestApiClient restApiClient, ISurpassLanguageVariantApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Returns a detailed response for Language Variant of item set
        /// </summary>
        /// <param name="id">Parent item set id</param>
        /// <param name="languageCode">Language code of Language Variant item set</param>
        /// <returns>Item set Language Variant resource</returns>
        public TimeZonePageResponse<LvItemSetResource> Get(int id, string languageCode)
        {
            return _restApiClient.CallGet<TimeZonePageResponse<LvItemSetResource>>(_urlFormatter.GetForIdAndCode(id, languageCode));
        }

        /// <summary>
        /// Allows creation of item set language variants
        /// </summary>
        /// <param name="id">Parent item set id</param>
        /// <param name="lvItemSetInput">Body of Language Variant of item set</param>
        /// <returns>Short info about created Language Variant of item set</returns>
        public PostLvResponseModel Post(int id, LvItemSetInputResource lvItemSetInput)
        {
            return _restApiClient.CallPost<PostLvResponseModel, LvItemSetInputResource>(
                _urlFormatter.GetForParentId(id),
                lvItemSetInput);
        }

        /// <summary>
        /// Allows updating of language variants of item set
        /// </summary>
        /// <param name="id">Parent item set id</param>
        /// <param name="languageCode">Language code of Language Variant of item set</param>
        /// <param name="lvItemSetUpdate">Body of Language Variant of item set</param>
        /// <returns>Short info about updated Language Variant item</returns>
        public PostLvResponseModel Put(int id, string languageCode, LvItemSetUpdateResource lvItemSetUpdate)
        {
            return _restApiClient.CallPut<PostLvResponseModel, LvItemSetUpdateResource>(
                _urlFormatter.GetForIdAndCode(id, languageCode),
                lvItemSetUpdate);
        }

        /// <summary>
        /// Allows deletion of Language Variant of item set
        /// </summary>
        /// <param name="id">Parent item set id</param>
        /// <param name="languageCode">Language code of Language Variant of item set</param>
        /// <returns>TimeZonePostResponseModel</returns>
        public TimeZonePostResponseModel Delete(int id, string languageCode)
        {
            return _restApiClient.CallDelete<TimeZonePostResponseModel>(
                _urlFormatter.GetForIdAndCode(id, languageCode));
        }
    }
}
