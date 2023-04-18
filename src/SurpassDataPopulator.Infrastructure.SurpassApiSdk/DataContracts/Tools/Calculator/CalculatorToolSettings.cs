using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Tools.Calculator
{
    [DataContract(Namespace = "")]
    public class CalculatorToolSettings : ItemToolSettingsBase
    {
        [DefaultValue(CalculatorMode.Basic)]
        [DataMember(Name = ApiConsts.Members.Mode, Order = 10)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CalculatorMode Mode { get; set; }

        [DataMember(Name = ApiConsts.Members.Label, Order = 20)]
        public string Label { get; set; }
    }
}
