using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.TestProfile.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.TestProfile
{
    [DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
    [ControllerName(ApiConsts.Segments.TestProfile, 2)]
    public class TestProfileDetailedResource : LinkedResource
    {
        [DataMember(Name = ApiConsts.Members.ProfileName, EmitDefaultValue = true)]
        public string ProfileName { get; set; }

        [DataMember(Name = ApiConsts.Members.IsPublished, EmitDefaultValue = true)]
        public bool? IsPublished { get; set; }

        [DataMember(Name = ApiConsts.Members.ShowAlertsInFrontOfAllWindows, EmitDefaultValue = true)]
        [DefaultValue(false)]
        public bool ShowAlertsInFrontOfAllWindows { get; set; }

        [DataMember(Name = ApiConsts.Members.WarningIntervals, EmitDefaultValue = true)]
        public string WarningIntervals { get; set; }

        [DataMember(Name = ApiConsts.Members.Deleted, EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        [DataMember(Name = ApiConsts.Members.WindowPosition, EmitDefaultValue = true)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [DefaultValue(SurpassApiDeliveryWindowPosition.Central)]
        public SurpassApiDeliveryWindowPosition WindowPosition { get; set; }

        [DataMember(Name = ApiConsts.Members.HeaderFooter, EmitDefaultValue = true)]
        public TestProfileColorsResource HeaderFooterColours { get; set; }

        [DataMember(Name = ApiConsts.Members.FinishButton, EmitDefaultValue = true)]
        public TestProfileColorsResource FinishButtonColours { get; set; }

        [DataMember(Name = ApiConsts.Members.PrimaryButton, EmitDefaultValue = true)]
        public TestProfileColorsResource PrimaryButtonColours { get; set; }

        [DataMember(Name = ApiConsts.Members.SecondaryButton, EmitDefaultValue = true)]
        public TestProfileColorsResource SecondButtonColours { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateDetails, EmitDefaultValue = true)]
        public TestProfileCandidateDetailsResource CandidateDetails { get; set; }

        [DataMember(Name = ApiConsts.Members.ClientLogo, EmitDefaultValue = true)]
        public TestProfileDetailLogoResource ClientLogo { get; internal set; }

        [DataMember(Name = ApiConsts.Members.ProviderLogo, EmitDefaultValue = true)]
        public TestProfileDetailLogoResource ProviderLogo { get; internal set; }

        [DataMember(Name = ApiConsts.Members.ScoreReportTemplate, EmitDefaultValue = true)]
        public TestProfileDetailScoreReportTemplateResource ScoreReportTemplate { get; set; }

        [DataMember(Name = ApiConsts.Members.ContentManifestFile, EmitDefaultValue = true)]
        public TestProfileFileOutputResource ContentManifestFile { get; set; }

        [DataMember(Name = ApiConsts.Members.SupportingInfoFile, EmitDefaultValue = true)]
        public TestProfileFileOutputResource SupportingInfoFile { get; set; }

        [DataMember(Name = ApiConsts.Members.DeliveryPresentation, EmitDefaultValue = true)]
        public TestProfileDeliveryPresentationResource DeliveryPresentation { get; set; }

        [DataMember(Name = ApiConsts.Members.CandidateReview, EmitDefaultValue = true)]
        public TestProfileCandidateReviewResource CandidateReview { get; set; }
    }
}
