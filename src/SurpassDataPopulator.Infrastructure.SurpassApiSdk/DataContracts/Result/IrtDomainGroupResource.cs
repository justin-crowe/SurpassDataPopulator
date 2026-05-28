using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.IrtDomainGroup, Namespace = "")]
public class IrtDomainGroupResource
{
    [DataMember(Name = ApiConsts.Members.Name)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.IrtTheta)]
    public decimal? IrtScore { get; set; }

    [DataMember(Name = ApiConsts.Members.ScaleScore)]
    public decimal? ScaleScore { get; set; }
}