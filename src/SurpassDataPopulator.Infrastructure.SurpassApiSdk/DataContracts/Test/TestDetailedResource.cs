using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test
{
    [DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
    public class TestDetailedResource : BaseTestResource
    {
        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false)]
        public SubjectLinkedResource Subject { get; set; }
    }
}
