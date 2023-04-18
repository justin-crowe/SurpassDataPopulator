using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.TestSession
{
    [DataContract(Name = ApiConsts.Contracts.TestSession, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TestSession, 2)]
    public class TestSessionDetailedResource : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Keycode, EmitDefaultValue = false, Order = 3)]
        public string Keycode { get; set; }

        [DataMember(Name = ApiConsts.Members.TestState, EmitDefaultValue = false, Order = 4)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SurpassApiExamState ExamState { get; set; }

        [DataMember(Name = ApiConsts.Members.Test, EmitDefaultValue = false, Order = 5)]
        public NamedHrefResource Test { get; set; }

        [DataMember(Name = ApiConsts.Members.Centre, EmitDefaultValue = false, Order = 6)]
        public LinkedResource Centre { get; set; }

        [DataMember(Name = ApiConsts.Members.Candidate, EmitDefaultValue = false, Order = 7)]
        public LinkedResource Candidate { get; set; }

        [DataMember(Name = ApiConsts.Members.StartDate, EmitDefaultValue = false, Order = 9)]
        public string StartDate { get; set; }

        [DataMember(Name = ApiConsts.Members.EndDate, EmitDefaultValue = false, Order = 10)]
        public string EndDate { get; set; }

        [DataMember(Name = ApiConsts.Members.StartTime, EmitDefaultValue = false, Order = 11)]
        public string StartTime { get; set; }

        [DataMember(Name = ApiConsts.Members.EndTime, EmitDefaultValue = false, Order = 12)]
        public string EndTime { get; set; }

        [DataMember(Name = ApiConsts.Members.TestForm, EmitDefaultValue = false, Order = 13)]
        public NamedHrefResource TestForm { get; set; }

        [DataMember(Name = ApiConsts.Members.LocalState, EmitDefaultValue = true, Order = 14)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SurpassApiExamState? LocalState { get; set; }

        [DataMember(Name = ApiConsts.Members.Duration, EmitDefaultValue = false, Order = 15)]
        public int Duration { get; set; }

        [DataMember(Name = ApiConsts.Members.RequiresInvigilation, EmitDefaultValue = false, Order = 16)]
        public bool RequiresInvigilation { get; set; }

        [DataMember(Name = ApiConsts.Members.ExternalReference, EmitDefaultValue = true, Order = 17)]
        public string ExternalReference { get; set; }

        [DataMember(Name = ApiConsts.Members.PurchaseOrder, EmitDefaultValue = false, Order = 18)]
        public string PurchaseOrder { get; set; }

        [DataMember(Name = ApiConsts.Members.TestActivatedInfo, EmitDefaultValue = false, Order = 19)]
        public TestSessionActivatedInfoResource TestActivatedInfo { get; set; }

        [DataMember(Name = ApiConsts.Members.VoidReason, EmitDefaultValue = false, Order = 20)]
        public string VoidReason { get; set; }

        [DataMember(Name = ApiConsts.Members.QualityReview, EmitDefaultValue = false, Order = 18)]
        public bool QualityReview { get; set; }

        [DataMember(Name = ApiConsts.Members.DownloadedToSecureClient, EmitDefaultValue = true, Order = 21)]
        public bool DownloadedToSecureClient { get; set; }

        [DataMember(Name = ApiConsts.Members.Downloads, EmitDefaultValue = false, Order = 22)]
        public IEnumerable<TestSessionDownloadInfoResource> Downloads { get; set; }

        [DataMember(Name = ApiConsts.Members.CreationDate, EmitDefaultValue = false, Order = 8)]
        public string CreationDate { get; set; }

        [DataMember(Name = ApiConsts.Members.AvailableMarks, EmitDefaultValue = false, Order = 23)]
        public int? AvailableMarks { get; set; }

        [DataMember(Name = ApiConsts.Members.Mark, EmitDefaultValue = false, Order = 24)]
        public double? Mark { get; set; }

        [DataMember(Name = ApiConsts.Members.Sections, EmitDefaultValue = false, Order = 25)]
        public IEnumerable<SectionResource> Sections { get; set; }

        [DataMember(Name = ApiConsts.Members.RequiresCheckIn, EmitDefaultValue = true, Order = 26)]
        public bool RequiresCheckIn { get; set; }

        [DataMember(Name = ApiConsts.Members.TestSessionFiles, EmitDefaultValue = true, Order = 27)]
        public IEnumerable<LinkedIdResource> Files { get; set; }
    }
}
