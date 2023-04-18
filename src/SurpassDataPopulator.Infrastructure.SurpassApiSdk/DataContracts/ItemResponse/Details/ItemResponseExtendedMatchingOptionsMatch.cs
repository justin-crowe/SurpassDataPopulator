using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    public class ItemResponseExtendedMatchingOptionsMatch
    {
        [DataMember(Name = ApiConsts.Members.LeftBoxId, EmitDefaultValue = false, Order = 1)]
        public int LeftOption { get; set; }

        [DataMember(Name = ApiConsts.Members.RightBoxId, EmitDefaultValue = false, Order = 2)]
        public int RightOption { get; set; }
    }
}
