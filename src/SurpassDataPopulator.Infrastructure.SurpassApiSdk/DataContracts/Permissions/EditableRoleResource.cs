using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Permissions
{
    [DataContract(Name = ApiConsts.Contracts.Permission, Namespace = "")]
    public class EditableRoleResource
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.Disabled, Order = 1, EmitDefaultValue = false)]
        public bool Disabled { get; set; }
    }
}
