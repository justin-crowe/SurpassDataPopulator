using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Task.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.ItemReview;

[DataContract(Name = ApiConsts.Contracts.ItemReviewTask, Namespace = "")]
[ControllerName(ApiConsts.Segments.ItemReviewTask, 2)]
public class ItemReviewTaskDetailedExtendedResource : ItemTaskWithStatusDetailedResource
{
}