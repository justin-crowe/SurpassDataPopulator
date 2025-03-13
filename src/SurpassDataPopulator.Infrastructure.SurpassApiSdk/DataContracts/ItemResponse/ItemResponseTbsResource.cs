using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.ItemResponse.Details;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseTbsResource : ItemResponseBaseResource
{
    [DataMember(Name = ApiConsts.Members.Tbs.MoList, EmitDefaultValue = false)]
    public List<ItemResponseTbsMo> MoList { get; set; }
}