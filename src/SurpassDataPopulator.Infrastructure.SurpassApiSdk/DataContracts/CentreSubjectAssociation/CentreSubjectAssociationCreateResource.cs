using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.CentreSubjectAssociation;

[DataContract(Name = ApiConsts.Contracts.CentreSubjectAssociation, Namespace = "")]
public class CentreSubjectAssociationCreateResource : CentreSubjectAssociationUpdateResource
{
    [DataMember(Name = ApiConsts.Members.Centre, Order = 0)]
    public Resource Centre { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject, Order = 1)]
    public Resource Subject { get; set; }
}