using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Name = ApiConsts.Contracts.Task, Namespace = "")]
public abstract class TaskCreateResource : TaskCreateUpdateResource
{
    [CustomGenerator("Date")]
    [DataMember(Name = ApiConsts.Members.StartDate, Order = 3)]
    public DateTime StartDate { get; set; }

    [CustomGenerator("Date")]
    [DataMember(Name = ApiConsts.Members.ExpiryDate, Order = 4)]
    public DateTime ExpiryDate { get; set; }
}