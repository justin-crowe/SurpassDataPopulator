using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class MatchingBoxMatchResource
    {
        [DataMember(Name = ApiConsts.Members.LeftBoxId, EmitDefaultValue = true)]
        public long LeftBoxId { get; set; }

        [DataMember(Name = ApiConsts.Members.RightBoxId, EmitDefaultValue = true)]
        public long RightBoxId { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark, EmitDefaultValue = true)]
        public int? Weight { get; set; }
    }
}
