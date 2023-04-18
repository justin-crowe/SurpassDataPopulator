using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Folder
{
    /// <summary>
    /// Represents a base folder properties
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Folder, Namespace = "")]
    public class FolderInputResource
    {
        [DataMember(Name = ApiConsts.Members.Name, Order = 0, EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
        public ItemSubjectResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.ParentFolderId, EmitDefaultValue = false)]
        public long? ParentFolderId { get; set; }

        [DataMember(Name = ApiConsts.Members.Position, EmitDefaultValue = false)]
        public int Position { get; set; }
    }
}
