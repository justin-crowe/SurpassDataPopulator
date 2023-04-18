using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item
{
    [ControllerName(ApiConsts.Segments.Item, 2)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class ItemHrefResourceBase
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Id, Order = 0)]
        public long Id { get; set; }

        /// <summary>
        /// Resource Href
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Href, Order = 2)]
        [NotSortable]
        [NotFilterable]
        public string Href { get; set; }
    }
}
