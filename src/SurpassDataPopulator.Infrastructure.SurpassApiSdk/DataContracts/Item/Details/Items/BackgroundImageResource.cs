using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [DataContract(Name = ApiConsts.Contracts.BackgroundImage, Namespace = "")]
    public class BackgroundImageResource
    {
        [DataMember(Name = ApiConsts.Members.MediaItem, EmitDefaultValue = true)]
        public MediaItemDetailResource MediaItem { get; set; }

        [DataMember(Name = ApiConsts.Members.Height, EmitDefaultValue = true)]
        public int? Height { get; set; }

        [DataMember(Name = ApiConsts.Members.Width, EmitDefaultValue = true)]
        public int? Width { get; set; }
    }
}
