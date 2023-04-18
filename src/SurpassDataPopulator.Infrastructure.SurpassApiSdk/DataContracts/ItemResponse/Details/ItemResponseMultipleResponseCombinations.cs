using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
    public class ItemResponseMultipleResponseCombinations
    {
        [DataMember(Name = ApiConsts.Members.Mark, Order = 1, EmitDefaultValue = true)]
        public int Mark { get; set; }

        [DataMember(Name = ApiConsts.Members.Name, Order = 2, EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Selected, Order = 3, EmitDefaultValue = false)]
        public bool Selected { get; set; }

        [DataMember(Name = ApiConsts.Members.Options, Order = 4, EmitDefaultValue = false)]
        public List<ItemDetailResource> Options { get; set; }
    }
}
