using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [CollectionSize(1)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class LikertItemUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.IsMatrixMode, EmitDefaultValue = true, Order = 1)]
        public bool? IsMatrixMode { get; set; }

        [DataMember(Name = ApiConsts.Members.OptionList, EmitDefaultValue = true, Order = 2)]
        public virtual LikertItemOptionListResource OptionList { get; set; }

        [DataMember(Name = ApiConsts.Members.StatementList, EmitDefaultValue = true, Order = 3)]
        public virtual LikertItemStatementListResource StatementList { get; set; }
    }
}
