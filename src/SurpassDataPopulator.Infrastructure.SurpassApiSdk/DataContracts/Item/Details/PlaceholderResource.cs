using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
public class PlaceholderResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public long Id { get; set; }

    [DataMember(Name = ApiConsts.Members.OrderNumber, EmitDefaultValue = true)]
    public int OrderNumber { get; set; }

    [DataMember(Name = ApiConsts.Members.PlaceholderOptions, EmitDefaultValue = true)]
    public IEnumerable<PlaceholderAlternativeResource> PlaceholderOptions { get; set; }
}