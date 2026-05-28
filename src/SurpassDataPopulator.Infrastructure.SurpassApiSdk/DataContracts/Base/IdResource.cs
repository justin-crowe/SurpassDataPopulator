using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base;

[DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
public class IdResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
    public int? Id { get; set; }
}