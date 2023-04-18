using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemStatementList, Namespace = "")]
    public class LikertItemStatementListUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.Statements, EmitDefaultValue = true)]
        public IEnumerable<LikertItemStatementUpdateResource> Statements { get; set; }
    }
}
