using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.SecureClient
{
    [DataContract(Name = ApiConsts.Contracts.SecureClient, Namespace = "")]
    public class SecureClientResource
    {
        [DataMember(Name = ApiConsts.Members.HasAccess, Order = 1)]
        public bool HasAccess { get; set; }
    }
}
