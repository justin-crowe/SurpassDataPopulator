using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Comment;
using SurpassApiSdk.DataContracts.Folder;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.ItemTagValue;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.Tools;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Interfaces.DataContracts;

namespace SurpassApiSdk.DataContracts.BasicPage
{
    [DataContract(Name = ApiConsts.Contracts.BasicPage, Namespace = "")]
    [ControllerName(ApiConsts.Segments.BasicPage, 2)]
    public class BasicPageResource : LinkedResource, ICommentedEntity
    {
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = true)]
        public SubjectLinkedResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.Folder, EmitDefaultValue = true)]
        public FolderLinkedResource Folder { get; set; }

        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemTypeKey Type { get; set; }

        [DataMember(Name = ApiConsts.Members.QuestionText, EmitDefaultValue = true)]
        public string QuestionText { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlText, EmitDefaultValue = true)]
        public string HtmlText { get; set; }

        [DataMember(Name = ApiConsts.Members.ContentType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ContentTypeKey ContentType { get; set; }

        [DataMember(Name = ApiConsts.Members.MathMl, EmitDefaultValue = true)]
        public string MathMl { get; set; }

        [DataMember(Name = ApiConsts.Members.AssistiveMedia, EmitDefaultValue = true)]
        public AssistiveMediaLinkedResource AssistiveMedia { get; set; }

        [DataMember(Name = ApiConsts.Members.AdditionalHtmlText, EmitDefaultValue = true)]
        public string AdditionalHtmlText { get; set; }

        [DataMember(Name = ApiConsts.Members.AdditionalMathMl, EmitDefaultValue = true)]
        public string AdditionalMathMl { get; set; }

        [DataMember(Name = ApiConsts.Members.AdditionalContentType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ContentTypeKey AdditionalContentType { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, EmitDefaultValue = true)]
        public string Status { get; set; }

        [DataMember(Name = ApiConsts.Members.Comment, EmitDefaultValue = true)]
        public string Comment { get; set; }

        [DataMember(Name = ApiConsts.Members.PrivateComment, EmitDefaultValue = true)]
        public bool CommentIsPrivate { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaItems, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> MediaItems { get; set; }

        [DataMember(Name = ApiConsts.Members.SourceMaterials, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> SourceMaterials { get; set; }

        [DataMember(Name = ApiConsts.Members.SubjectItemTagValues, EmitDefaultValue = true)]
        public IEnumerable<SubjectItemTagValueResource> SubjectItemTagValues { get; set; }

        [DataMember(Name = ApiConsts.Members.StemComponents, EmitDefaultValue = true)]
        public IEnumerable<MultimediaComponentResource> StemComponents { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowOpenImageInPopup, EmitDefaultValue = true)]
        public bool? AllowOpenImageInPopup { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaLayout, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemMediaLayout? MediaLayout { get; set; }

        [DataMember(Name = ApiConsts.Members.Deleted, EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        [DataMember(Name = ApiConsts.Members.Tools, EmitDefaultValue = true)]
        public IEnumerable<ItemToolResource> Tools { get; set; }

        [DataMember(Name = ApiConsts.Members.Owner)]
        public UserResource Owner { get; set; }

        [DataMember(Name = ApiConsts.Members.Comments)]
        public List<CommentResource> Comments { get; set; }
    }
}
