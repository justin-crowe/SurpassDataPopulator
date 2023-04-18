using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseExtendedMatchingResource : ItemResponseBaseResource
    {
        [DataMember(Name = ApiConsts.Members.WeightedMarking, EmitDefaultValue = false, Order = 7)]
        public bool WeightedMarking { get; set; }

        [DataMember(Name = ApiConsts.Members.LinkType, EmitDefaultValue = false, Order = 8)]
        public string LinkingType { get; set; }

        [DataMember(Name = ApiConsts.Members.LeftBoxes, EmitDefaultValue = false, Order = 9)]
        public List<ItemResponseExtendedMatchingLeftItem> LeftBox { get; set; }

        [DataMember(Name = ApiConsts.Members.RightBoxes, EmitDefaultValue = false, Order = 10)]
        public List<ItemResponseExtendedMatchingRightItem> RightBox { get; set; }

        [DataMember(Name = ApiConsts.Members.Links, EmitDefaultValue = false, Order = 11)]
        public List<ItemResponseExtendedMatchingCorrectMatch> CorrectMatches { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateResponse, EmitDefaultValue = false, Order = 12)]
        public List<ItemResponseExtendedMatchingOptionsMatch> Matches { get; set; }
    }
}
