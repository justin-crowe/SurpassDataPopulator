using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.WorkflowStatus;

/// <summary>
/// Represents a workflow status that has name property
/// </summary>
[ControllerName(ApiConsts.Segments.WorkflowStatus, 2)]
[DataContract(Name = ApiConsts.Contracts.WorkflowStatus, Namespace = "")]
public class WorkflowStatusResource : NamedResource
{
    [IgnoreDataMember]
    public new string Reference { get; set; }
}