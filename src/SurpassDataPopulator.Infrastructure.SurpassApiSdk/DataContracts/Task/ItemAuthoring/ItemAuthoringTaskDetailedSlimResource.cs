using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemAuthoring;

[DataContract(Name = ApiConsts.Contracts.ItemAuthoringTask, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemAuthoringTask, 2)]
public class ItemAuthoringTaskDetailedSlimResource : ItemTaskDetailedSlimResource
{
}