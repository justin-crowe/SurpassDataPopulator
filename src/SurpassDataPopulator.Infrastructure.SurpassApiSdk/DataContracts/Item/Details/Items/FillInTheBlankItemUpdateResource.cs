using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [CollectionSize(1)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class FillInTheBlankItemUpdateResource : PlaceholderCommonItemResource
    {
        [DataMember(Name = ApiConsts.Members.RequireCaseSensitive, EmitDefaultValue = true)]
        public bool? RequireCaseSensitive { get; set; }
    }
}
