using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.County;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Country;

[ControllerName(ApiConsts.Segments.Country, 2)]
[DataContract(Name = ApiConsts.Contracts.Country, Namespace = "")]
public class CountryDetailedResource : LinkedResource
{
    [DataMember(Name = ApiConsts.Members.Name, Order = 3)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Counties, Order = 4)]
    [NotSortable]
    [NotFilterable]
    public IList<CountyLinkedResource> Counties { get; set; }
}