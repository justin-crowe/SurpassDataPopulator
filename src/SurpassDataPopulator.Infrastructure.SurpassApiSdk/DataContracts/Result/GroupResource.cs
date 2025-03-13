using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.Group, Namespace = "")]
public class GroupResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 1)]
    public int Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Name, Order = 2)]
    public string Name { get; set; }
}