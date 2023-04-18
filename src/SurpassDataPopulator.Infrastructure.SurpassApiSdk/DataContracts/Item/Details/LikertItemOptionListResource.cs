using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemOptionList, Namespace = "")]
    public class LikertItemOptionListResource
    {
        [DataMember(Name = ApiConsts.Members.Options, EmitDefaultValue = true)]
        public IEnumerable<LikertItemOptionResource> Options { get; set; }
    }
}
