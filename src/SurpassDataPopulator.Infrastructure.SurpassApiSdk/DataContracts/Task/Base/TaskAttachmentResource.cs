using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task.Base
{
    [DataContract(Name = ApiConsts.Contracts.TaskAttachment, Namespace = "")]
    [ControllerName(ApiConsts.Segments.Attachment, 2)]
    public class TaskAttachmentResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.FileName, Order = 1)]
        public string FileName { get; set; }

        [DataMember(Name = ApiConsts.Members.FileSize, Order = 2)]
        public long FileSize { get; set; }

        [DataMember(Name = ApiConsts.Members.Href, Order = 1)]
        [NotSortable]
        [NotFilterable]
        public string Href { get; set; }
    }
}
