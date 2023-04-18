using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Subject
{
    [DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
    public class SubjectCreateResource
    {
        [DataMember(Name = ApiConsts.Members.Reference)]
        public string Reference { get; set; }

        [DataMember(Name = ApiConsts.Members.Name)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.PrimaryCentre)]
        public Resource PrimaryCentre { get; set; }

        [DataMember(Name = ApiConsts.Members.DeliveryType)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DeliveryType DeliveryType { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlOnly)]
        [DefaultValue(false)]
        public bool HtmlOnly { get; set; }

        [DataMember(Name = ApiConsts.Members.UseMasterList)]
        [DefaultValue(false)]
        public bool UseMasterList { get; set; }

        [DataMember(Name = ApiConsts.Members.EnableCheckboxesInItemAuthoring)]
        [DefaultValue(true)]
        public bool EnableCheckboxesInItemAuthoring { get; set; }
    }
}
