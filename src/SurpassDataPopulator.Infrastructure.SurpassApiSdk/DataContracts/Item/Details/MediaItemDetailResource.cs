using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details
{
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class MediaItemDetailResource : ItemDetailResource
    {
        [DataMember(Name = ApiConsts.Members.ExternalId, EmitDefaultValue = false)]
        public string ExternalId { get; set; }
    }
}
