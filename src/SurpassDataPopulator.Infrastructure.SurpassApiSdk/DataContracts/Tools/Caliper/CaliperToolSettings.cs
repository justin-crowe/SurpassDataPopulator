using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Tools.Caliper
{
    [DataContract(Namespace = "")]
    public class CaliperToolSettings : ItemToolSettingsBase
    {
        [DefaultValue(CaliperMode.Pixels)]
        [DataMember(Name = ApiConsts.Members.Mode, Order = 10)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public CaliperMode Mode { get; set; }

        [DataMember(Name = ApiConsts.Members.Label, Order = 20)]
        public string Label { get; set; }
    }
}
