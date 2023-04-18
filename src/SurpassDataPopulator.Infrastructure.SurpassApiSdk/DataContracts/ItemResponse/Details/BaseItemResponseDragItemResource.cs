using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    [DataContract(Name = ApiConsts.Contracts.DragItem, Namespace = "")]
    public class BaseItemResponseDragItemResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 1)]
        public string Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Value, Order = 2)]
        public string Value { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaId, Order = 3, EmitDefaultValue = false)]
        public int? MediaId { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaName, Order = 4, EmitDefaultValue = false)]
        public string MediaName { get; set; }
    }
}
