using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Metadata
{
    [DataContract(Name = ApiConsts.Contracts.Metadata, Namespace = "")]
    [ControllerName(ApiConsts.Members.Metadata, 2)]
    public class MetadataResource : MetadataBaseResource
    {
        [DataMember(Name = ApiConsts.Members.Type, Order = 4)]
        public string Type { get; set; }

        [DataMember(Name = ApiConsts.Members.Data, Order = 5)]
        public string Data { get; set; }
    }
}
