using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.TestSession
{
    [DataContract]
    public class TestSessionStateUpdateResource
    {
        [DefaultValue(SurpassApiExamState.InProgress)]
        [DataMember(Name = ApiConsts.Members.TestState, Order = 1)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SurpassApiExamState TestState { get; set; }

        [DefaultValue(SurpassApiVoidReason.Absent)]
        [DataMember(Name = ApiConsts.Members.VoidReason, Order = 2)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SurpassApiVoidReason? VoidReason { get; set; }

        [DefaultValue("string")]
        [DataMember(Name = ApiConsts.Members.VoidMessage, Order = 3)]
        public string VoidMessage { get; set; }

        [DefaultValue(false)]
        [DataMember(Name = ApiConsts.Members.ForceLocalVoid, Order = 4)]
        public bool ForceLocalVoid { get; set; }

        [DefaultValue(null)]
        [DataMember(Name = ApiConsts.Members.OfflineDelivery, Order = 5)]
        public bool? OfflineDelivery { get; set; }
    }
}
