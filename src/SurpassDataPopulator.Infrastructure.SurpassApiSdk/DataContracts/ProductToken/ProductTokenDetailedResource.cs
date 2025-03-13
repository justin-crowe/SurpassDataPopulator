using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ProductToken;

[DataContract(Name = ApiConsts.Contracts.ProductToken, Namespace = "")]
public class ProductTokenDetailedResource
{
    [DataMember(Name = ApiConsts.Members.Token, Order = 1)]
    public string Token { get; set; }
}