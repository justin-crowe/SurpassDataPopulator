using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Permissions;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.CentreSubjectAssociation;

[DataContract(Name = ApiConsts.Contracts.CentreSubjectAssociation, Namespace = "")]
[ControllerName(ApiConsts.Segments.CentreSubjectAssociation, 2)]
public class CentreSubjectAssociationDetailedResource : CentreSubjectAssociationResource
{
    [DataMember(Name = ApiConsts.Members.Primary, Order = 3)]
    public bool Primary { get; set; }

    [DataMember(Name = ApiConsts.Members.Permissions, Order = 4)]
    public IEnumerable<RoleResource> Roles { get; set; }
}