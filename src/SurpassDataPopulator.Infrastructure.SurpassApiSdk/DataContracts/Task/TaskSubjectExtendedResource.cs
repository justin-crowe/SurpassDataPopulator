using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Task
{
    [ControllerName(ApiConsts.Segments.Subject, 2)]
    [DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
    public class TaskSubjectExtendedResource : SubjectLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 4)]
        public string Name { get; set; }
    }
}
