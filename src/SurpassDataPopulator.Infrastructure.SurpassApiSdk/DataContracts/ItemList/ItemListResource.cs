using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.ItemList
{
    [ControllerName(ApiConsts.Segments.ItemList, 2)]
    [DataContract(Name = ApiConsts.Contracts.ItemList, Namespace = "")]
    public class ItemListResource : LinkedResource
    {
    }
}
