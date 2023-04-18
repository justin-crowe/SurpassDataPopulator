using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item
{
    [ControllerName(ApiConsts.Segments.Item, 2)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class ItemLinkedResourceBase
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public long Id { get; set; }
    }
}
