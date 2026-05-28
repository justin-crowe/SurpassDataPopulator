using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.ItemStatementList, Namespace = "")]
public class LikertItemStatementListResource
{
    [DataMember(Name = ApiConsts.Members.Statements, EmitDefaultValue = true)]
    public IEnumerable<LikertItemStatementResource> Statements { get; set; }
}