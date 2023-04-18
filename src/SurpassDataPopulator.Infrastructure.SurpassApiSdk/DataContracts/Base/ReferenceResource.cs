using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Base
{
    /// <summary>
    /// Represents a simple resource with Reference
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
    public abstract class ReferenceResource
    {
        /// <summary>
        /// Resource Reference
        /// </summary>
        [DataMember(Name = ApiConsts.Members.Reference, Order = 1, EmitDefaultValue = false)]
        public virtual string Reference { get; set; }
    }
}
