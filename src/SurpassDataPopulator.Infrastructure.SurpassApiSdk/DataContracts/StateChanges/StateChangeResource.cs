using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.StateChanges
{
    [DataContract(Name = ApiConsts.Contracts.StateChange, Namespace = "")]
    public class StateChangeResource
    {
        [DataMember(Name = ApiConsts.Members.NewState, EmitDefaultValue = false, Order = 51)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SurpassApiExamState State { get; set; }

        [DataMember(Name = ApiConsts.Members.Date, EmitDefaultValue = false, Order = 52)]
        public DateTime DateTime { get; set; }

        [DataMember(Name = ApiConsts.Members.Type, EmitDefaultValue = true, Order = 53)]
        public string Type { get; set; }

        [DataMember(Name = ApiConsts.Members.Reason, EmitDefaultValue = true, Order = 54)]
        public string Reason { get; set; }

        [DataMember(Name = ApiConsts.Members.User, EmitDefaultValue = true, Order = 55)]
        public AspireUserResource User { get; set; }

        [DataMember(Name = ApiConsts.Members.Description, EmitDefaultValue = true, Order = 56)]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.Columns, EmitDefaultValue = true, Order = 57)]
        public List<ColumnResource> Columns { get; set; }

        [DataMember(Name = ApiConsts.Members.ExternalUserReference, EmitDefaultValue = true, Order = 58)]
        public string ExternalUserRef { get; set; }
    }
}
