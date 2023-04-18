using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.County
{
    [ControllerName(ApiConsts.Segments.County, 2)]
    [DataContract(Name = ApiConsts.Contracts.County, Namespace = "")]
    public class CountyLinkedResource : LinkedIdResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 3)]
        public string Name { get; set; }
    }
}
