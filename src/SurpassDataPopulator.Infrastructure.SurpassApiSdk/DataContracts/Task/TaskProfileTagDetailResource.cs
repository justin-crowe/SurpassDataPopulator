using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.TagGroup;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task;

[ControllerName(ApiConsts.Segments.TaskProfileTagDetails, 2)]
[DataContract(Name = ApiConsts.Contracts.TaskProfileTagDetails, Namespace = "")]
public class TaskProfileTagDetailResource
{
    [DataMember(Name = ApiConsts.Members.TagTypeName, Order = 1)]
    public string TagTypeName { get; set; }

    [DataMember(Name = ApiConsts.Members.TagTypeKey, Order = 2)]
    public SubjectTagTypeKey TagTypeKey { get; set; }
}