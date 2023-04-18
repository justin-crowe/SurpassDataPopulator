using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Section
{
    [DataContract(Name = ApiConsts.Members.AdditionalMediaReplays, Namespace = "")]
    public class AdditionalMediaReplayResource
    {
        [DataMember(Name = ApiConsts.Members.Value, Order = 1)]
        public int? Value { get; set; }
    }
}
