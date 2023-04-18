using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Base.Interfaces;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base
{
    /// <summary>
    /// Represents a simple resource with Id and Href
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
    public class LinkedIdResource : ILinkedIdResource
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = false)]
        public long? Id { get; set; }

        /// <summary>
        /// Resource Href
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Href, Order = 1)]
        [NotSortable]
        [NotFilterable]
        public string Href { get; set; }
    }
}
