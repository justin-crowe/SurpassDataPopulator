using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Section
{
    [DataContract(Name = ApiConsts.Members.DecisionPoint, Namespace = "")]
    public class DecisionPointResource
    {
        [DataMember(Name = ApiConsts.Members.UpperValue, Order = 1)]
        public decimal? UpperValue { get; set; }

        [DataMember(Name = ApiConsts.Members.LowerValue, Order = 2)]
        public decimal? LowerValue { get; set; }

        [DataMember(Name = ApiConsts.Members.ValueType, Order = 3)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ESectionPassMarkType? ValueType { get; set; }

        [DataMember(Name = ApiConsts.Members.SectionsToCheck, Order = 4)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ESectionsToCheck? SectionsToCheck { get; set; }
    }
}
