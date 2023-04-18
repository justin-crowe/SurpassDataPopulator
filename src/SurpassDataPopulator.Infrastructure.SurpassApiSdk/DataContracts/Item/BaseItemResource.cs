using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Item.Details.Items;
using SurpassApiSdk.DataContracts.Tools;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class BaseItemResource
    {
        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Folder, EmitDefaultValue = true)]
        public ItemFolderResource Folder { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.MarkScheme, EmitDefaultValue = true)]
        public ItemMarkSchemeResource MarkScheme { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.QuestionText, EmitDefaultValue = true)]
        public string QuestionText { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlText, EmitDefaultValue = true)]
        public string HtmlText { get; set; }

        [DataMember(Name = ApiConsts.Members.MathMl, EmitDefaultValue = true)]
        public string MathMl { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark, EmitDefaultValue = true)]
        public int? Mark { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Citations, EmitDefaultValue = true)]
        public string Citations { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SeedUsageCount, EmitDefaultValue = true)]
        public int? SeedUsageCount { get; set; }

        [ConditionalMemberIgnore]
        [DefaultValue(1.0)]
        [DataMember(Name = ApiConsts.Members.SeedPValue, EmitDefaultValue = true)]
        public double? SeedPValue { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, EmitDefaultValue = true)]
        public string Status { get; set; }

        public int? StatusId { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ItemPurpose, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemPurposeKey? ItemPurpose { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.MarkingType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MarkingTypeKey? MarkingType { get; set; }

        [DataMember(Name = ApiConsts.Members.Comment, EmitDefaultValue = true)]
        public string Comment { get; set; }

        [DataMember(Name = ApiConsts.Members.PrivateComment)]
        public bool CommentIsPrivate { get; set; }

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

        [DataMember(Name = ApiConsts.Members.MultipleChoiceQuestions, EmitDefaultValue = true)]
        public IEnumerable<MultipleChoiceItemUpdateResource> MultipleChoiceQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.MultipleResponseQuestions, EmitDefaultValue = true)]
        public IEnumerable<MultipleResponseItemUpdateResource> MultipleResponseQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.EssayQuestions, EmitDefaultValue = true)]
        public IEnumerable<EssayItemUpdateResource> EssayQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ShortAnswerQuestions, EmitDefaultValue = true)]
        public IEnumerable<ShortAnswerItemUpdateResource> ShortAnswerQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.EitherOrQuestions, EmitDefaultValue = true)]
        public IEnumerable<EitherOrItemUpdateResource> EitherOrQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.NumericalEntryQuestions, EmitDefaultValue = true)]
        public IEnumerable<NumericalEntryItemUpdateResource> NumericalEntryQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.FillInTheBlankQuestions, EmitDefaultValue = true)]
        public IEnumerable<FillInTheBlankItemUpdateResource> FillInTheBlankQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.VoiceCaptureQuestions, EmitDefaultValue = true)]
        public IEnumerable<VoiceCaptureItemUpdateResource> VoiceCaptureQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.LikertQuestions, EmitDefaultValue = true)]
        public IEnumerable<LikertItemUpdateResource> LikertQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ExtendedMatchingQuestions, EmitDefaultValue = true)]
        public IEnumerable<MatchingBoxesItemUpdateResource> MatchingBoxesQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SelectFromAListQuestions, EmitDefaultValue = true)]
        public IEnumerable<SelectFromAListItemUpdateResource> SelectFromAListQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.FileAttachQuestions, EmitDefaultValue = true)]
        public IEnumerable<FileAttachItemUpdateResource> FileAttachQuestions { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.DragDropQuestions, EmitDefaultValue = true)]
        public IEnumerable<DragAndDropItemUpdateResource> DragAndDropQuestions { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowOpenImageInPopup, EmitDefaultValue = true)]
        public bool? AllowOpenImageInPopup { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaLayout, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemMediaLayout? MediaLayout { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.EnemyItems, EmitDefaultValue = true)]
        public List<ItemLinkedResourceBase> EnemyItems { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.SectionEnemyItems, EmitDefaultValue = true)]
        public List<ItemLinkedResourceBase> SectionEnemyItems { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ItemSet, EmitDefaultValue = true)]
        public ItemItemSetResource ItemSet { get; set; }

        [DataMember(Name = ApiConsts.Members.Tools, EmitDefaultValue = true)]
        public IEnumerable<ItemToolResource> Tools { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.Owner, EmitDefaultValue = true)]
        public ItemOwnerResource Owner { get; set; }

        [ConditionalMemberIgnore]
        [DataMember(Name = ApiConsts.Members.ItemPackage, EmitDefaultValue = false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValue(null)]
        public byte[] ItemPackage { get; set; }
    }
}
