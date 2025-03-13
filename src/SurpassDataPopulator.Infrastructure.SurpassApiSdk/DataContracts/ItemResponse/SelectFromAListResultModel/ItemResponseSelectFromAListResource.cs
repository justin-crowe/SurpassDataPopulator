using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.SelectFromAListResultModel;

[DataContract(Name = ApiConsts.Contracts.ItemResponse, Namespace = "")]
public class ItemResponseSelectFromAListResource : ItemResponseBaseResource
{
    [DataMember(Name = ApiConsts.Members.OptionsList, Order = 1)]
    public List<SelectFromAListPlaceholderModel> PlaceholdersList { get; set; }
}