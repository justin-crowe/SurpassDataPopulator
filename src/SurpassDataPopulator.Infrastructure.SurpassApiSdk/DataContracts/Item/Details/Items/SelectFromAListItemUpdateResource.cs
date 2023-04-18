using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [CollectionSize(1)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class SelectFromAListItemUpdateResource : PlaceholderCommonItemResource
    {
        [DataMember(Name = ApiConsts.Members.OrderOptionsAlphabetically, EmitDefaultValue = true)]
        public bool? OrderOptionsAlphabetically { get; set; }
    }
}
