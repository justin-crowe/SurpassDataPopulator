using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Metadata;
using SurpassApiSdk.DataContracts.Section;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.Test;
using SurpassApiSdk.DataContracts.TestForm.Details;
using SurpassApiSdk.DataContracts.TestForm.Enums;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm
{
    [ControllerName(ApiConsts.Segments.TestForm, 2)]
    [DataContract(Name = ApiConsts.Contracts.TestForm, Namespace = "")]
    public class TestFormInputResource : Resource
    {
        [DataMember(Name = ApiConsts.Members.Name, IsRequired = true, EmitDefaultValue = false, Order = 4)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, IsRequired = true, EmitDefaultValue = true, Order = 5)]
        public SubjectResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.Test, IsRequired = true, EmitDefaultValue = true, Order = 6)]
        public TestResource Test { get; set; }

        [DataMember(Name = ApiConsts.Members.Metadata, EmitDefaultValue = false, Order = 7)]
        public List<MetadataInputResource> Metadata { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, EmitDefaultValue = true, Order = 8)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TestFormStatuses Status { get; set; }

        [DataMember(Name = ApiConsts.Members.ValidFromDate, EmitDefaultValue = true, Order = 9)]
        public DateTime ValidFrom { get; set; }

        [DataMember(Name = ApiConsts.Members.ValidToDate, EmitDefaultValue = true, Order = 10)]
        public DateTime ValidTo { get; set; }

        [DataMember(Name = ApiConsts.Members.Timing, EmitDefaultValue = true, Order = 11)]
        public TestFormTimingResource Timing { get; set; }

        [DataMember(Name = ApiConsts.Members.ReasonableAdjustmentsStandard, EmitDefaultValue = false, Order = 12)]
        public int ReasonableAdjustmentsStandard { get; set; }

        [DataMember(Name = ApiConsts.Members.ReasonableAdjustmentsMax, EmitDefaultValue = false, Order = 13)]
        public int ReasonableAdjustmentsMax { get; set; }

        [DataMember(Name = ApiConsts.Members.ExcludeFromRandomTestFormSelection, EmitDefaultValue = false, Order = 14)]
        public bool ExcludeFromRandomTestFormSelection { get; set; }

        [DataMember(Name = ApiConsts.Members.GradeBoundaries, EmitDefaultValue = true, Order = 15)]
        public TestFormGradeBoundariesResource GradeBoundaries { get; set; }

        [DataMember(Name = ApiConsts.Members.RoundToDecimalPlaces, EmitDefaultValue = false, Order = 16)]
        public int? RoundToDecimalPlaces { get; set; }

        [DataMember(Name = ApiConsts.Members.Printable, EmitDefaultValue = false, Order = 17)]
        public bool Printable { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowCloseWithoutSubmit, EmitDefaultValue = true, Order = 18)]
        public bool AllowCloseWithoutSubmit { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowUseAsTemplate, EmitDefaultValue = false, Order = 19)]
        public bool AllowUseAsTemplate { get; set; }

        [DataMember(Name = ApiConsts.Members.RequiresModeration, EmitDefaultValue = false, Order = 20)]
        public bool RequiresModeration { get; set; }

        [DataMember(Name = ApiConsts.Members.RequiresSecureMarker, EmitDefaultValue = false, Order = 21)]
        public bool RequiresSecureMarker { get; set; }

        [DataMember(Name = ApiConsts.Members.AdvanceContentDownloadTimespan, EmitDefaultValue = false, Order = 22)]
        public int AdvanceContentDownloadTimespan { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackPassFail, EmitDefaultValue = false, Order = 23)]
        public bool TestFeedbackPassFail { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackPercentageMark, EmitDefaultValue = false, Order = 24)]
        public bool TestFeedbackPercentageMark { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackShowFeedbackButtonDuringTest, EmitDefaultValue = false, Order = 25)]
        public bool TestFeedbackShowFeedbackButtonDuringTest { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackSummaryFeedback, EmitDefaultValue = true, Order = 26)]
        public TestFormSummaryFeedbackResource SummaryFeedback { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemComments, EmitDefaultValue = false, Order = 27)]
        public bool ItemComments { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFormComments, EmitDefaultValue = false, Order = 28)]
        public string TestFormComments { get; set; }

        [DataMember(Name = ApiConsts.Members.Section, IsRequired = true, EmitDefaultValue = true, Order = 29)]
        public List<SectionInputResource> Section { get; set; }
    }
}
