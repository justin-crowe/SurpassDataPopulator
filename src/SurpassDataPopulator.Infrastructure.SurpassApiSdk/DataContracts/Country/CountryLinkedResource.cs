using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Country;

[ControllerName(ApiConsts.Segments.Country, 2)]
[DataContract(Name = ApiConsts.Contracts.Country, Namespace = "")]
public class CountryLinkedResource : LinkedIdResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 2)]
    public string Name { get; set; }
}