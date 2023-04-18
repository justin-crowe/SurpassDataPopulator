using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class DragAndDropMatchResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 1, EmitDefaultValue = false)]
        public string Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Value, Order = 2, EmitDefaultValue = false)]
        public string Value { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaId, Order = 3, EmitDefaultValue = false)]
        public int? MediaId { get; set; }

        [DataMember(Name = ApiConsts.Members.MediaName, Order = 4, EmitDefaultValue = false)]
        public string MediaName { get; set; }

        [DataMember(Name = ApiConsts.Members.AwardedMark, Order = 5)]
        public int? AwardedMark { get; set; }

        [DataMember(Name = ApiConsts.Members.IsCorrect, Order = 6)]
        public bool? IsCorrect { get; set; }
    }
}
