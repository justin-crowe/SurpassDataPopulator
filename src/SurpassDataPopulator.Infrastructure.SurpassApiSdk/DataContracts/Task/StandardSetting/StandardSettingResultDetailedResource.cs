using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.StandardSetting;

[ControllerName(ApiConsts.Segments.StandardSettingResult, 2)]
[DataContract(Name = ApiConsts.Contracts.StandardSettingResult, Namespace = "")]
public class StandardSettingResultDetailedResource : ILinkedResource
{
    [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
    public long? Id { get; set; }

    [DataMember(Name = ApiConsts.Members.Href, Order = 1)]
    public string Href { get; set; }

    [DataMember(Name = ApiConsts.Members.ExternalItemId, Order = 2)]
    public long ExternalItemId { get; set; }

    [DataMember(Name = ApiConsts.Members.ExternalItemVersion, EmitDefaultValue = false, Order = 3)]
    public string ExternalItemVersion { get; set; }

    [DataMember(Name = ApiConsts.Members.ExternalSubjectId, Order = 4)]
    public long ExternalSubjectId { get; set; }

    [DataMember(Name = ApiConsts.Members.ResultLastModifiedDate, Order = 5)]
    public DateTime LastModifiedDate { get; set; }

    [DataMember(Name = ApiConsts.Members.TaskExecutor, Order = 6)]
    public UserResource TaskExecutor { get; set; }

    [DataMember(Name = ApiConsts.Members.IsFlagged, Order = 7)]
    public bool IsFlagged { get; set; }

    [DataMember(Name = ApiConsts.Members.IsSubmitted, Order = 8)]
    public bool IsSubmitted { get; set; }

    [DataMember(Name = ApiConsts.Members.RatingMethodResults, Order = 9)]
    public ICollection<TaskRatingMethodOptionResource> RatingMethodResults { get; set; }

    [DataMember(Name = ApiConsts.Members.ResultComment, Order = 10)]
    public string Comment { get; set; }
}