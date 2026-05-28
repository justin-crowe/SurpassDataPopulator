using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Name = ApiConsts.Contracts.Task, Namespace = "")]
public abstract class TaskCreateUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Reference, Order = 0)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.Name, Order = 1)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Description, Order = 2)]
    public string Description { get; set; }
}