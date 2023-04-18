using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Media;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.MediaGroup
{
    [ControllerName(ApiConsts.Segments.MediaGroup, 2)]
    [DataContract(Name = ApiConsts.Contracts.MediaGroup, Namespace = "")]
    public class MediaGroupDetailedResource : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
        public SubjectLinkedResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = true)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Description, EmitDefaultValue = true)]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.Media, EmitDefaultValue = true)]
        public IList<MediaLinkedResource> Media { get; set; }

        [DataMember(Name = ApiConsts.Members.Group, EmitDefaultValue = false)]
        public MediaGroupLinkedResource Group { get; set; }
    }
}
