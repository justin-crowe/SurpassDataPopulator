using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemMultipleResponseOptions : ItemResponseOptions
    {
        [DataMember(Name = ApiConsts.Members.ExclusiveOption, Order = 10, EmitDefaultValue = true)]
        public bool ExclusiveOption { get; set; }
    }
}
