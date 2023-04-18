using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Folder
{
    [DataContract(Name = ApiConsts.Contracts.Folder, Namespace = "")]
    [ControllerName(ApiConsts.Segments.Folder, 2)]
    public class FolderUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.Name, Order = 0, EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.ParentFolderId, EmitDefaultValue = false)]
        public long? ParentFolderId { get; set; }

        [DataMember(Name = ApiConsts.Members.Position, EmitDefaultValue = false)]
        public int? Position { get; set; }
    }
}
