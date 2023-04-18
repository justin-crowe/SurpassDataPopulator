using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Metadata;
using SurpassApiSdk.DataContracts.Section;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.Test;
using SurpassApiSdk.DataContracts.TestForm.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm
{
    [ControllerName(ApiConsts.Segments.TestForm, 2)]
    [DataContract(Name = ApiConsts.Contracts.TestForm, Namespace = "")]
    public class TestFormDetailedResource : TestFormResource
    {
        [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false, Order = 4)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, EmitDefaultValue = false, Order = 5)]
        public SubjectLinkedResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.Test, EmitDefaultValue = false, Order = 6)]
        public TestLinkedResource Test { get; set; }

        [DataMember(Name = ApiConsts.Members.Section, EmitDefaultValue = false, Order = 7)]
        public List<SectionNestedResource> Section { get; set; }

        [DataMember(Name = ApiConsts.Members.Metadata, EmitDefaultValue = false, Order = 8)]
        public List<MetadataBaseResource> Metadata { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, EmitDefaultValue = false, Order = 9)]
        public string Status { get; set; }

        /// <summary>
        /// test form valid from date
        /// </summary>
        [DataMember(Name = ApiConsts.Members.ValidFromDate, EmitDefaultValue = true, Order = 10)]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// test form valid to date
        /// </summary>
        [DataMember(Name = ApiConsts.Members.ValidToDate, EmitDefaultValue = true, Order = 11)]
        public DateTime ValidTo { get; set; }

        [DataMember(Name = ApiConsts.Members.Timing, EmitDefaultValue = true, Order = 12)]
        public TestFormTimingResource Timing { get; set; }

        [DataMember(Name = ApiConsts.Members.ReasonableAdjustmentsStandard, EmitDefaultValue = true, Order = 13)]
        public int ReasonableAdjustmentsStandard { get; set; }

        [DataMember(Name = ApiConsts.Members.ReasonableAdjustmentsMax, EmitDefaultValue = true, Order = 14)]
        public int ReasonableAdjustmentsMax { get; set; }

        [DataMember(Name = ApiConsts.Members.ExcludeFromRandomTestFormSelection, EmitDefaultValue = true, Order = 15)]
        public bool ExcludeFromRandomTestFormSelection { get; set; }

        [DataMember(Name = ApiConsts.Members.GradeBoundaries, EmitDefaultValue = true, Order = 16)]
        public TestFormGradeBoundariesResource GradeBoundaries { get; set; }

        [DataMember(Name = ApiConsts.Members.RoundToDecimalPlaces, EmitDefaultValue = true, Order = 17)]
        public int? RoundToDecimalPlaces { get; set; }

        [DataMember(Name = ApiConsts.Members.Printable, EmitDefaultValue = true, Order = 18)]
        public bool Printable { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowCloseWithoutSubmit, EmitDefaultValue = true, Order = 19)]
        public bool AllowCloseWithoutSubmit { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowUseAsTemplate, EmitDefaultValue = true, Order = 20)]
        public bool AllowUseAsTemplate { get; set; }

        [DataMember(Name = ApiConsts.Members.RequiresModeration, EmitDefaultValue = true, Order = 21)]
        public bool RequiresModeration { get; set; }

        [DataMember(Name = ApiConsts.Members.RequiresSecureMarker, EmitDefaultValue = true, Order = 22)]
        public bool RequiresSecureMarker { get; set; }

        [DataMember(Name = ApiConsts.Members.AdvanceContentDownloadTimespan, EmitDefaultValue = true, Order = 23)]
        public int AdvanceContentDownloadTimespan { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackPassFail, EmitDefaultValue = true, Order = 24)]
        public bool TestFeedbackPassFail { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackPercentageMark, EmitDefaultValue = true, Order = 25)]
        public bool TestFeedbackPercentageMark { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackShowFeedbackButtonDuringTest, EmitDefaultValue = true, Order = 26)]
        public bool TestFeedbackShowFeedbackButtonDuringTest { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFeedbackSummaryFeedback, EmitDefaultValue = true, Order = 27)]
        public TestFormSummaryFeedbackResource SummaryFeedback { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemComments, EmitDefaultValue = true, Order = 28)]
        public bool ItemComments { get; set; }

        [DataMember(Name = ApiConsts.Members.TestFormComments, EmitDefaultValue = true, Order = 29)]
        public string TestFormComments { get; set; }
    }
}
