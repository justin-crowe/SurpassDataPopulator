using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.TestProfile.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.TestProfile;

[DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
[ControllerName(ApiConsts.Segments.TestProfile, 2)]
public class TestProfileInputResource
{
    [DataMember(Name = ApiConsts.Members.ProfileName, EmitDefaultValue = true)]
    public string ProfileName { get; set; }

    [DataMember(Name = ApiConsts.Members.IsPublished, EmitDefaultValue = true)]
    public bool? IsPublished { get; set; }

    [DataMember(Name = ApiConsts.Members.ShowAlertsInFrontOfAllWindows, EmitDefaultValue = true)]
    [DefaultValue(false)]
    public bool ShowAlertsInFrontOfAllWindows { get; set; }

    [DataMember(Name = ApiConsts.Members.WarningIntervals, EmitDefaultValue = true)]
    [DefaultValue("30,15,5")]
    public string WarningIntervals { get; set; }

    [DataMember(Name = ApiConsts.Members.WindowPosition, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [DefaultValue(SurpassApiDeliveryWindowPosition.Central)]
    public SurpassApiDeliveryWindowPosition WindowPosition { get; set; }

    [DataMember(Name = ApiConsts.Members.ProviderLogoColor, EmitDefaultValue = true)]
    public TestProfileLogoResource ProviderLogoColor { get; set; }

    [DataMember(Name = ApiConsts.Members.ProviderLogoMonochrome, EmitDefaultValue = true)]
    public TestProfileLogoResource ProviderLogoMonochrome { get; set; }

    [DataMember(Name = ApiConsts.Members.ClientLogoColor, EmitDefaultValue = true)]
    public TestProfileLogoResource ClientLogoColor { get; set; }

    [DataMember(Name = ApiConsts.Members.ClientLogoMonochrome, EmitDefaultValue = true)]
    public TestProfileLogoResource ClientLogoMonochrome { get; set; }

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

    [DataMember(Name = ApiConsts.Members.ScoreReportTemplate, EmitDefaultValue = true)]
    public TestProfileScoreReportResource ScoreReportTemplate { get; set; }

    [DataMember(Name = ApiConsts.Members.ContentManifestFile, EmitDefaultValue = true)]
    public TestProfileManifestFileInputResource ContentManifestFile { get; set; }

    [DataMember(Name = ApiConsts.Members.SupportingInfoFile, EmitDefaultValue = true)]
    public TestProfileSupportingInfoFileInputResource SupportingInfoFile { get; set; }

    [DataMember(Name = ApiConsts.Members.DeliveryPresentation, EmitDefaultValue = true)]
    public TestProfileDeliveryPresentationResource DeliveryPresentation { get; set; }

    [DataMember(Name = ApiConsts.Members.CandidateReview, EmitDefaultValue = true)]
    public TestProfileCandidateReviewResource CandidateReview { get; set; }
}