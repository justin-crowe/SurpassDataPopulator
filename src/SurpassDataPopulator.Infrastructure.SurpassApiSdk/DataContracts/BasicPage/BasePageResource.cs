using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.DataContracts.Tools;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.BasicPage
{
    [DataContract(Name = ApiConsts.Contracts.BasicPage, Namespace = "")]
    public class BasePageResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlText, EmitDefaultValue = true)]
        public string HtmlText { get; set; }

        [DataMember(Name = ApiConsts.Members.MathMl, EmitDefaultValue = true)]
        public string MathMl { get; set; }

        [DataMember(Name = ApiConsts.Members.ContentType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter ))]
        public ContentTypeKey? ContentType { get; set; }

        [DataMember(Name = ApiConsts.Members.AdditionalHtmlText, EmitDefaultValue = true)]
        public string AdditionalHtmlText { get; set; }

        [DataMember(Name = ApiConsts.Members.AdditionalMathMl, EmitDefaultValue = true)]
        public string AdditionalMathMl { get; set; }

        [DataMember(Name = ApiConsts.Members.AdditionalContentType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ContentTypeKey? AdditionalContentType { get; set; }

        [DataMember(Name = ApiConsts.Members.Folder, EmitDefaultValue = true)]
        public ItemFolderResource Folder { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, EmitDefaultValue = true)]
        public string Status { get; set; }

        public int? StatusId { get; set; }

        [DataMember(Name = ApiConsts.Members.Comment, EmitDefaultValue = true)]
        public string Comment { get; set; }

        [DataMember(Name = ApiConsts.Members.PrivateComment, EmitDefaultValue = true)]
        public bool CommentIsPrivate { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaItems, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> MediaItems { get; set; }

        [DataMember(Name = ApiConsts.Members.SourceMaterials, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> SourceMaterials { get; set; }

        [DataMember(Name = ApiConsts.Members.StemComponents, EmitDefaultValue = true)]
        public IEnumerable<MultimediaComponentResource> StemComponents { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowOpenImageInPopup, EmitDefaultValue = true)]
        public bool? AllowOpenImageInPopup { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaLayout, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ItemMediaLayout? MediaLayout { get; set; }

        [DataMember(Name = ApiConsts.Members.AssistiveMedia, EmitDefaultValue = true)]
        public AssistiveMediaInputResource AssistiveMedia { get; set; }

        [DataMember(Name = ApiConsts.Members.Tools, EmitDefaultValue = true)]
        public IEnumerable<ItemToolResource> Tools { get; set; }

        [DataMember(Name = ApiConsts.Members.Owner, EmitDefaultValue = true)]
        public ItemOwnerResource Owner { get; set; }
    }
}
