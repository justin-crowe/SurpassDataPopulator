using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base
{
    /// <summary>
    /// Represents a <see cref="Resource"/> that has href and id property and that doesn't emit default values when property is null
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
    public class ConcealDefaultsLinkedResource
    {
        /// <summary>
        /// Resource Id
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Id, Order = 0, EmitDefaultValue = false)]
        public long? Id { get; set; }

        /// <summary>
        /// Resource Href
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Href, Order = 1, EmitDefaultValue = false)]
        [NotSortable]
        [NotFilterable]
        public string Href { get; set; }
    }
}
