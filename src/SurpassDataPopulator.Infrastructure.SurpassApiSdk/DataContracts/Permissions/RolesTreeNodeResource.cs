using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Permissions
{
    [DataContract(Name = ApiConsts.Contracts.RolesTreeNode, Namespace = "")]
    public class RolesTreeNodeResource
    {
        public RolesTreeNodeResource()
        {
            Roles = new List<RolesTreeNodeResource>();
        }

        [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = false)]
        public int? Id { get; set; }

        [DataMember(Name = ApiConsts.Members.IsRoot, Order = 1, EmitDefaultValue = false)]
        public bool IsRoot { get; set; }

        [DataMember(Name = ApiConsts.Members.Name, Order = 2)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Description, Order = 3)]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.Roles, Order = 4, EmitDefaultValue = false)]
        public IList<RolesTreeNodeResource> Roles { get; set; }

        [DataMember(Name = ApiConsts.Members.NotAssignable, Order = 5, EmitDefaultValue = false)]
        public bool NotAssignable { get; set; }
    }
}
