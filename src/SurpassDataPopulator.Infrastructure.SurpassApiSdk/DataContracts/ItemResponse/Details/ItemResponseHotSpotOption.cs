using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseHotSpotOption
{
    [DataMember(Name = ApiConsts.Members.Coordinates, EmitDefaultValue = false, Order = 1)]
    public string Coordinate { get; set; }
}