using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.Folder, Namespace = "")]
    public class ItemFolderResource
    {
        [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Position, EmitDefaultValue = true)]
        public int Position { get; set; }
    }
}
