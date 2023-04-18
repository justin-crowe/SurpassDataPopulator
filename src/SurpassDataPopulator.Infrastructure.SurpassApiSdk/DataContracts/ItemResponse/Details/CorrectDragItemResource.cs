using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    [DataContract(Name = ApiConsts.Contracts.DragItem, Namespace = "")]
    public class CorrectDragItemResource : BaseItemResponseDragItemResource
    {
        [DataMember(Name = ApiConsts.Members.Mark, Order = 3)]
        public int? Mark { get; set; }
    }
}
