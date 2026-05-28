using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base;

[DataContract(Name = ApiConsts.Contracts.Task, Namespace = "")]
public class TaskLinkedResource : LinkedResource
{
}