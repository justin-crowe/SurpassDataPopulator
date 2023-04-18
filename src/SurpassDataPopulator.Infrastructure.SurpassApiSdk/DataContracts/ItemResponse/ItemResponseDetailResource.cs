using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.SelectFromAListResultModel;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    [ControllerName(ApiConsts.Segments.ItemResponse, 2)]
    public class ItemResponseDetailResource : ItemResponseLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.MultipleChoiceQuestions, Order = 1, EmitDefaultValue = false)]
        public List<ItemResponseMultipleChoiceResource> MultipleChoiceModel { get; set; }

        [DataMember(Name = ApiConsts.Members.MultipleResponseQuestions, Order = 2, EmitDefaultValue = false)]
        public List<ItemResponseMultipleResponseResource> MultipleResponseModel { get; set; }

        [DataMember(Name = ApiConsts.Members.EitherOrQuestions, Order = 3, EmitDefaultValue = false)]
        public List<ItemResponseEitherOrQuestionResource> EitherOrModel { get; set; }

        [DataMember(Name = ApiConsts.Members.UnsupportedQuestionTypes, Order = 4, EmitDefaultValue = false)]
        public List<ItemResponseUnsupportedQuestionTypeResource> UnsupportedQuestionTypesModel { get; set; }

        [DataMember(Name = ApiConsts.Members.VoiceCaptureQuestions, Order = 5, EmitDefaultValue = false)]
        public List<ItemResponseVoiceCaptureQuestionTypeResource> VoiceCaptureModel { get; set; }

        [DataMember(Name = ApiConsts.Members.AlgorithmResponseData, Order = 6, EmitDefaultValue = false)]
        public string AlgorithmResponseData { get; set; }

        [DataMember(Name = ApiConsts.Members.FileAttachQuestions, Order = 6, EmitDefaultValue = false)]
        public List<ItemResponseFileAttachQuestionTypeResource> FileAttachModel { get; set; }

        [DataMember(Name = ApiConsts.Members.LikertQuestions, Order = 7, EmitDefaultValue = false)]
        public List<ItemResponseLikertQuestionTypeResource> LikertModel { get; set; }

        [DataMember(Name = ApiConsts.Members.Tbs.Questions, Order = 8, EmitDefaultValue = false)]
        public List<ItemResponseTbsResource> TbsModel { get; set; }

        [DataMember(Name = ApiConsts.Members.DragAndDropQuestions, Order = 9, EmitDefaultValue = false)]
        public List<ItemResponseDragAndDropResource> DragAndDropModel { get; set; }

        [DataMember(Name = ApiConsts.Members.NumericalEntryQuestions, Order = 10, EmitDefaultValue = false)]
        public IEnumerable<ItemResponseNumericEntryResource> NumericalEntryModel { get; set; }

        [DataMember(Name = ApiConsts.Members.ShortAnswerQuestions, Order = 11, EmitDefaultValue = false)]
        public List<ItemResponseShortAnswerResource> ShortAnswerModel { get; set; }

        [DataMember(Name = ApiConsts.Members.ExtendedMatchingQuestions, Order = 12, EmitDefaultValue = false)]
        public List<ItemResponseExtendedMatchingResource> ExtendedMatchingModel { get; set; }

        [DataMember(Name = ApiConsts.Members.HotSpotQuestions, Order = 13, EmitDefaultValue = false)]
        public List<ItemResponseHotSpotResource> HotSpotModel { get; set; }

        [DataMember(Name = ApiConsts.Members.EssayQuestions, Order = 14, EmitDefaultValue = false)]
        public List<ItemResponseEssayResource> EssayModel { get; set; }

        [DataMember(Name = ApiConsts.Members.SelectFromAListQuestions, Order = 15, EmitDefaultValue = false)]
        public List<ItemResponseSelectFromAListResource> SelectFromAListModel { get; set; }

        public bool Contains(string cpid)
        {
            Func<ItemResponseBaseResource, bool> containsFunc = model => string.Equals(
                model.Id,
                cpid,
                StringComparison.OrdinalIgnoreCase);

            return EitherOrModel.Any(containsFunc)
                   || MultipleChoiceModel.Any(containsFunc)
                   || MultipleResponseModel.Any(containsFunc)
                   || UnsupportedQuestionTypesModel.Any(containsFunc)
                   || VoiceCaptureModel.Any(containsFunc)
                   || FileAttachModel.Any(containsFunc)
                   || LikertModel.Any(containsFunc)
                   || TbsModel.Any(containsFunc)
                   || DragAndDropModel.Any(containsFunc)
                   || NumericalEntryModel.Any(containsFunc)
                   || ShortAnswerModel.Any(containsFunc)
                   || ExtendedMatchingModel.Any(containsFunc)
                   || HotSpotModel.Any(containsFunc)
                   || EssayModel.Any(containsFunc)
                   || SelectFromAListModel.Any(containsFunc);
        }
    }
}
