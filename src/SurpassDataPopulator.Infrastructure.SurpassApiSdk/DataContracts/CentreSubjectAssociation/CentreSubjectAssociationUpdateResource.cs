using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CentreSubjectAssociation
{
    [DataContract(Name = ApiConsts.Contracts.CentreSubjectAssociation, Namespace = "")]
    public class CentreSubjectAssociationUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.Permissions, Order = 3)]
        public IEnumerable<RoleResource> Roles { get; set; }
    }
}
