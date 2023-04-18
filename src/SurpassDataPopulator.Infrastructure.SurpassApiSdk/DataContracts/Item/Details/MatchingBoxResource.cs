using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class MatchingBoxResource
    {
        [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
        public long Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Text, EmitDefaultValue = true)]
        public string Text { get; set; }
    }
}
