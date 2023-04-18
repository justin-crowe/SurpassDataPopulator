using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class MatchingBoxesItemResource
    {
        [DataMember(Name = ApiConsts.Members.MatchingBoxesType, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public MatchingBoxesType? MatchingBoxesType { get; set; }

        [DataMember(Name = ApiConsts.Members.WeightedMarking, EmitDefaultValue = true)]
        public bool WeightedMarking { get; set; }

        [DataMember(Name = ApiConsts.Members.LeftBoxes, EmitDefaultValue = true)]
        public IEnumerable<MatchingBoxResource> LeftBoxes { get; set; }

        [DataMember(Name = ApiConsts.Members.RightBoxes, EmitDefaultValue = true)]
        public IEnumerable<MatchingBoxResource> RightBoxes { get; set; }

        [DataMember(Name = ApiConsts.Members.Links, EmitDefaultValue = true)]
        public IEnumerable<MatchingBoxMatchResource> Links { get; set; }

        [DataMember(Name = ApiConsts.Members.IsEnableManyToManyMarking, EmitDefaultValue = true)]
        public bool IsEnableManyToManyMarking { get; set; }
    }
}
