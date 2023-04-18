using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.CentreSubjectAssociation
{
    [ControllerName(ApiConsts.Segments.CentreSubjectAssociation, 2)]
    [DataContract(Name = ApiConsts.Contracts.CentreSubjectAssociation, Namespace = "")]
    public class CentreSubjectAssociationResource : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Centre, Order = 1)]
        public CentreLinkedResource Centre { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, Order = 2)]
        public SubjectLinkedResource Subject { get; set; }
    }
}
