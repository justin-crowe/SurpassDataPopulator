using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task;

[ControllerName(ApiConsts.Segments.TaskProfile, 2)]
[DataContract(Name = ApiConsts.Contracts.TaskProfile, Namespace = "")]
public class TaskProfileResource
{
    [DataMember(Name = ApiConsts.Members.TagsVisibilityType, Order = 1)]
    public TagsVisibilityType TagsVisibilityType { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskProfileTagDetails, Order = 2)]
    public ICollection<TaskProfileTagDetailResource> TaskProfileTagDetailResource { get; set; }

    [DataMember(Name = ApiConsts.Members.TagCollectionsVisibilityType, Order = 3)]
    public TagsVisibilityType TagCollectionsVisibilityType { get; set; }

    [DataMember(Name = ApiConsts.Members.TagCollectionCriteria, Order = 4)]
    public ICollection<TaskProfileTagCollectionCriterionResource> TagCollectionCriteria { get; set; }
}