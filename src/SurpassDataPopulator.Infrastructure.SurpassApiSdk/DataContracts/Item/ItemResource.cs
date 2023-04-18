using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Comment;
using SurpassApiSdk.DataContracts.Folder;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Item.Details.Items;
using SurpassApiSdk.DataContracts.Item.Details.Items.Tbs;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.DataContracts.ItemList;
using SurpassApiSdk.DataContracts.ItemSet;
using SurpassApiSdk.DataContracts.ItemTagValue;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.Tools;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Interfaces.DataContracts;

namespace SurpassApiSdk.DataContracts.Item
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    [ControllerName(ApiConsts.Segments.Item, 2)]
    public class ItemResource : LinkedResource, ICommentedEntity
    {
        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = true)]
        public SubjectLinkedResource Subject { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Folder, EmitDefaultValue = true)]
        public FolderLinkedResource Folder { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ItemSet, EmitDefaultValue = true)]
        public ItemSetLinkedResource ItemSet { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ItemType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemKind ItemType { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemMajorVersion, EmitDefaultValue = true)]
        public int ItemMajorVersion { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemVersion, EmitDefaultValue = true)]
        public int ItemVersion { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Deleted, EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.PublishId, EmitDefaultValue = true)]
        public string PublishId { get; set; }

        [DataMember(Name = ApiConsts.Members.QuestionText, EmitDefaultValue = true)]
        public string QuestionText { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlText, EmitDefaultValue = true)]
        public string HtmlText { get; set; }

        [DataMember(Name = ApiConsts.Members.MathMl, EmitDefaultValue = true)]
        public string MathMl { get; set; }

        [DataMember(Name = ApiConsts.Members.AssistiveMedia, EmitDefaultValue = true)]
        public AssistiveMediaLinkedResource AssistiveMedia { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark, EmitDefaultValue = true)]
        public int Mark { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Citations, EmitDefaultValue = true)]
        public string Citations { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SeedUsageCount, EmitDefaultValue = true)]
        public int? SeedUsageCount { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SeedPValue, EmitDefaultValue = true)]
        public double? SeedPValue { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, EmitDefaultValue = true)]
        public string Status { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ItemPurpose, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemPurposeKey ItemPurpose { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.MarkingType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MarkingTypeKey MarkingType { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.MarkingSchemeFileId, EmitDefaultValue = true)]
        public int? MarkingSchemeFileId { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.MarkingSchemeFileName, EmitDefaultValue = true)]
        public string MarkingSchemeFileName { get; set; }

        [DataMember(Name = ApiConsts.Members.Comment, EmitDefaultValue = true)]
        public string Comment { get; set; }

        [DataMember(Name = ApiConsts.Members.GeneralFeedback, EmitDefaultValue = true)]
        public ItemFeedbackResource GeneralFeedback { get; set; }

        [DataMember(Name = ApiConsts.Members.CorrectFeedback, EmitDefaultValue = true)]
        public ItemFeedbackResource CorrectFeedback { get; set; }

        [DataMember(Name = ApiConsts.Members.IncorrectFeedback, EmitDefaultValue = true)]
        public ItemFeedbackResource IncorrectFeedback { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaItems, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> MediaItems { get; set; }

        [DataMember(Name = ApiConsts.Members.SourceMaterials, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> SourceMaterials { get; set; }

        [DataMember(Name = ApiConsts.Members.StemComponents, EmitDefaultValue = true)]
        public IEnumerable<MultimediaComponentResource> StemComponents { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.DragDropQuestions, EmitDefaultValue = true)]
        public IEnumerable<DragAndDropItemUpdateResource> DragAndDropQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.MultipleChoiceQuestions, EmitDefaultValue = true)]
        public IEnumerable<MultipleChoiceItemResource> MultipleChoiceQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.MultipleResponseQuestions, EmitDefaultValue = true)]
        public IEnumerable<MultipleResponseItemResource> MultipleResponseQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.EssayQuestions, EmitDefaultValue = true)]
        public IEnumerable<EssayItemUpdateResource> EssayQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ShortAnswerQuestions, EmitDefaultValue = true)]
        public IEnumerable<ShortAnswerItemUpdateResource> ShortAnswerQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.EitherOrQuestions, EmitDefaultValue = true)]
        public IEnumerable<EitherOrItemResource> EitherOrQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.NumericalEntryQuestions, EmitDefaultValue = true)]
        public IEnumerable<NumericalEntryItemUpdateResource> NumericalEntryQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.FillInTheBlankQuestions, EmitDefaultValue = true)]
        public IEnumerable<FillInTheBlankItemUpdateResource> FillInTheBlankQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SelectFromAListQuestions, EmitDefaultValue = true)]
        public IEnumerable<SelectFromAListItemUpdateResource> SelectFromAListQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.VoiceCaptureQuestions, EmitDefaultValue = true)]
        public IEnumerable<VoiceCaptureItemUpdateResource> VoiceCaptureQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.LikertQuestions, EmitDefaultValue = true)]
        public IEnumerable<LikertItemResource> LikertQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.FileAttachQuestions, EmitDefaultValue = true)]
        public IEnumerable<FileAttachItemUpdateResource> FileAttachQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ExtendedMatchingQuestions, EmitDefaultValue = true)]
        public IEnumerable<MatchingBoxesItemResource> MatchingBoxesQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Tbs.Questions, EmitDefaultValue = true)]
        public IEnumerable<TbsItemResource> TbsQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowOpenImageInPopup, EmitDefaultValue = true)]
        public bool? AllowOpenImageInPopup { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaLayout, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemMediaLayout? MediaLayout { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SubjectItemTagValues)]
        public IEnumerable<SubjectItemTagValueResource> SubjectItemTagValues { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SubjectItemSetTagValues)]
        public IEnumerable<SubjectItemTagValueResource> SubjectItemSetTagValues { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.EnemyItems)]
        public List<ItemHrefResourceBase> EnemyItems { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SecondaryEnemyItems)]
        public List<ItemHrefResourceBase> SecondaryEnemyItems { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SectionEnemyItems)]
        public List<ItemHrefResourceBase> SectionEnemyItems { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SectionSecondaryEnemyItems)]
        public List<ItemHrefResourceBase> SectionSecondaryEnemyItems { get; set; }

        [DataMember(Name = ApiConsts.Members.Tools)]
        public IEnumerable<ItemToolResource> Tools { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Owner)]
        public UserResource Owner { get; set; }

        [DataMember(Name = ApiConsts.Members.Comments)]
        public List<CommentResource> Comments { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SharedWith)]
        public List<SubjectLinkedResource> SharedWith { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.StandardLists)]
        public List<ItemListResource> StandardLists { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.PublishStatus)]
        public ItemPublishingStatus PublishStatus { get; set; }

        [DataMember(Name = ApiConsts.Members.Language, EmitDefaultValue = true)]
        public LanguageResource Language { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.LanguageVariants, EmitDefaultValue = true)]
        public virtual IEnumerable<LanguageVariantResource> LanguageVariants { get; set; }
    }
}
