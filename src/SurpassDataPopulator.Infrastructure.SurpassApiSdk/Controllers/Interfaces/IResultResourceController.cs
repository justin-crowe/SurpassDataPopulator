using SurpassApiSdk.DataContracts.CandidateInteraction;
using SurpassApiSdk.DataContracts.ClientInformation;
using SurpassApiSdk.DataContracts.ItemResponse;
using SurpassApiSdk.DataContracts.Response;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.DataContracts.StateChanges;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface IResultResourceController
    {
        TimeZonePageResponse<ResultDetailedResource> Get(
            int id,
            bool showItemResponses = false,
            bool returnDownloadData = false);

        TimeZonePageResponse<ResultResource> Get(
            string queryString = null,
            bool markedExternally = false,
            bool includeExamsInMarking = false);

        TimeZonePageResponse<ResultDetailedResource> GetByKeycode(
            string keycode,
            bool showItemResponses = false,
            bool showAnalysis = false,
            bool returnDownloadData = false);

        TimeZonePageResponse<ItemResponseResource> GetItemResponses(
            int id,
            string queryString = null,
            bool markedExternally = false);

        TimeZonePageResponse<ItemResponseResource> GetItemResponses(
            string keycode,
            string queryString = null,
            bool markedExternally = false);

        TimeZonePageResponse<ItemResponseDetailResource> GetItemResponse(int id, string surpassReference);

        TimeZonePageResponse<ItemResponseDetailResource> GetItemResponse(string keycode, string surpassReference);

        TimeZonePageResponse<CandidateInteractionResource> GetCandidateInteraction(
            int id,
            bool includeDebugEvents = false);

        TimeZonePageResponse<CandidateInteractionResource> GetCandidateInteraction(
            string keycode,
            bool includeDebugEvents = false);

        TimeZonePageResponse<ClientInformationResource> GetClientInformation(int id);

        TimeZonePageResponse<ClientInformationResource> GetClientInformation(string reference);

        TimeZonePageResponse<StateChangesResource> GetStateChanges(int id);

        TimeZonePageResponse<StateChangesResource> GetStateChanges(string reference);

        TimeZonePageResponse<TbsTranslatedResultResource> TbsTranslation(
            string keycode,
            TbsTranslatedInputResultResource request);
    }
}
