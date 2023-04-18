using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Centre
{
    /// <summary>
    /// Represents a base centre properties
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.Centre, Namespace = "")]
    public class CentreUpdateResource : CentreCreateResource
    {
        [DataMember(Name = ApiConsts.Members.Status, Order = 2)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CentreStatus? Status { get; set; }
    }
}
