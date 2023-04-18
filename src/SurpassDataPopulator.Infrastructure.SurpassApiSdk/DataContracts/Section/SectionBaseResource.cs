using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Section
{
    [DataContract(Name = ApiConsts.Contracts.Section, Namespace = "")]
    [ControllerName(ApiConsts.Members.Section, 2)]
    public class SectionBaseResource : ConcealDefaultsLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Name, Order = 3)]
        public string Name { get; set; }
    }
}
