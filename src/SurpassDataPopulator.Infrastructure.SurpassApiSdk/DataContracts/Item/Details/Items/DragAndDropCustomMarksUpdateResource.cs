using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class DragAndDropCustomMarksUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.DragItem, EmitDefaultValue = true)]
        public int DragItem { get; set; }

        [DataMember(Name = ApiConsts.Members.DropZone, EmitDefaultValue = true)]
        public int DropZone { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark, EmitDefaultValue = true)]
        public int? Mark { get; set; }
    }
}
