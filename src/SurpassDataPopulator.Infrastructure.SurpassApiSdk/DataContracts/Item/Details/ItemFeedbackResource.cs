using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemFeedback, Namespace = "")]
    public class ItemFeedbackResource
    {
        [DataMember(Name = ApiConsts.Members.Text, EmitDefaultValue = true)]
        public string Text { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlText, EmitDefaultValue = true)]
        public string HtmlText { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaItems, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> MediaItems { get; set; }

        [DataMember(Name = ApiConsts.Members.SourceMaterials, EmitDefaultValue = true)]
        public IEnumerable<MediaItemDetailResource> SourceMaterials { get; set; }
    }
}
