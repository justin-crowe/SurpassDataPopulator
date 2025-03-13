using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Folder;

[ControllerName(ApiConsts.Segments.Folder, 2)]
[DataContract(Name = ApiConsts.Contracts.Folder, Namespace = "")]
public class FolderResource : LinkedResource
{
    /// <summary>
    /// Tag Value Name
    /// </summary>
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject)]
    public SubjectLinkedResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.ParentFolderId, EmitDefaultValue = true)]
    public long ParentFolderId { get; set; }

    [DataMember(Name = ApiConsts.Members.Deleted, EmitDefaultValue = true)]
    public bool Deleted { get; set; }
}