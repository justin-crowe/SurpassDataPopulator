using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.County;

[DataContract(Name = ApiConsts.Contracts.County, Namespace = "")]
[ControllerName(ApiConsts.Segments.County, 2)]
public class CountyTempLinkedResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 3)]
    public string Name { get; set; }
}