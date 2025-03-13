using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.MediaGroup;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Media;

[ControllerName(ApiConsts.Segments.Media, 2)]
[DataContract(Name = ApiConsts.Contracts.Media, Namespace = "")]
public class MediaDetailedResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
    public SubjectLinkedResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.Name, Order = 1, EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.EmbedLink, Order = 2, EmitDefaultValue = false)]
    public string EmbedLink { get; set; }

    [DataMember(Name = ApiConsts.Members.Group, Order = 3, EmitDefaultValue = false)]
    public MediaGroupLinkedResource Group { get; set; }

    [DataMember(Name = ApiConsts.Members.FileExtension, Order = 4, EmitDefaultValue = false)]
    public string FileExtension { get; set; }
}