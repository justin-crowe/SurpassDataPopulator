using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Subject
{
    [ControllerName(ApiConsts.Segments.Subject, 2)]
    [DataContract(Name = ApiConsts.Contracts.Subject, Namespace = "")]
    public class SubjectDetailedResource : SubjectLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Name)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.PrimaryCentre)]
        public CentreLinkedResource PrimaryCentre { get; set; }

        [DataMember(Name = ApiConsts.Members.Status)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SubjectStatus Status { get; set; }

        [DataMember(Name = ApiConsts.Members.DeliveryType)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public DeliveryType DeliveryType { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlOnly)]
        public bool HtmlOnly { get; set; }

        [DataMember(Name = ApiConsts.Members.UseMasterList)]
        public bool? UseMasterList { get; set; }

        [DataMember(Name = ApiConsts.Members.EnableCheckboxesInItemAuthoring)]
        public bool EnableCheckboxesInItemAuthoring { get; set; }
    }
}
