using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Centre
{
    [ControllerName(ApiConsts.Segments.Centre, 2)]
    [DataContract(Name = ApiConsts.Contracts.Centre, Namespace = "")]
    public class CentreWithNameResource : CentreResource
    {
        /// <summary>
        /// Centre Name
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 3)]
        public string Name { get; set; }
    }
}
