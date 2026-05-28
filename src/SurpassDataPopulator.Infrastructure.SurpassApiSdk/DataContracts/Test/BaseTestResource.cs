using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Test.Details;
using SurpassApiSdk.DataContracts.Test.Enums;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Test;

/// <summary>
/// Represents a base test properties
/// </summary>
[DataContract(Name = ApiConsts.Contracts.Test, Namespace = "")]
public class BaseTestResource
{
    [DataMember(Name = ApiConsts.Members.Name, EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = ApiConsts.Members.Reference, EmitDefaultValue = false)]
    public string Reference { get; set; }

    [DataMember(Name = ApiConsts.Members.Status, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TestStatus? Status { get; set; }

    [DataMember(Name = ApiConsts.Members.CertifiedAccessible, EmitDefaultValue = true)]
    public bool? CertifiedAccessible { get; set; }

    [DataMember(Name = ApiConsts.Members.UseAsTemplate, EmitDefaultValue = true)]
    public bool? UseAsTemplate { get; set; }

    [DataMember(Name = ApiConsts.Members.ExamType, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TestType? ExamType { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowTimeExtensionWhileInProgress, EmitDefaultValue = true)]
    public bool? AllowTimeExtensionWhileInProgress { get; set; }

    [DataMember(Name = ApiConsts.Members.AttemptAutoSubmit, EmitDefaultValue = true)]
    public bool? AttemptAutoSubmit { get; set; }

    [DataMember(Name = ApiConsts.Members.ResultsUploadGracePeriod, EmitDefaultValue = true)]
    public int? ResultsUploadGracePeriod { get; set; }

    [DataMember(Name = ApiConsts.Members.RequiresSecureClient, EmitDefaultValue = true)]
    public bool? RequiresSecureClient { get; set; }

    [DataMember(Name = ApiConsts.Members.RequiresBYODMode, EmitDefaultValue = true)]
    public bool? RequiresBYODMode { get; set; }

    [DataMember(Name = ApiConsts.Members.SecureClientMode, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SecureClientMode? SecureClientMode { get; set; }

    [DataMember(Name = ApiConsts.Members.RequiresInvigilation, EmitDefaultValue = true)]
    public bool? RequiresInvigilation { get; set; }

    [DataMember(Name = ApiConsts.Members.CertifiedForTabletDelivery, EmitDefaultValue = true)]
    public bool? CertifiedForTabletDelivery { get; set; }

    [DataMember(Name = ApiConsts.Members.NumberOfResits, EmitDefaultValue = true)]
    public int? NumberOfResits { get; set; }

    [DataMember(Name = ApiConsts.Members.ValidFromDate, EmitDefaultValue = true)]
    public DateTime? ValidFromDate { get; set; }

    [DataMember(Name = ApiConsts.Members.ExpiryDate, EmitDefaultValue = true)]
    public DateTime? ExpiryDate { get; set; }

    [DataMember(Name = ApiConsts.Members.TestWindowStartTime, EmitDefaultValue = true)]
    public string TestWindowStartTime { get; set; }

    [DataMember(Name = ApiConsts.Members.TestWindowEndTime, EmitDefaultValue = true)]
    public string TestWindowEndTime { get; set; }

    [DataMember(Name = ApiConsts.Members.RandomiseTestForms, EmitDefaultValue = true)]
    public bool? RandomiseTestForms { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowTestFormRecycling, EmitDefaultValue = true)]
    public bool? AllowTestFormRecycling { get; set; }

    [DataMember(Name = ApiConsts.Members.DeliveryOptions, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TestDeliveryOptions? DeliveryOptions { get; set; }

    [DataMember(Name = ApiConsts.Members.TestDistribution, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TestDistribution? TestDistribution { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkingType, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TestMarkingType? MarkingType { get; set; }

    [DataMember(Name = ApiConsts.Members.CandidateDetails, EmitDefaultValue = true)]
    public TestCandidateDetailsResource CandidateDetails { get; set; }

    [DataMember(Name = ApiConsts.Members.NDA, EmitDefaultValue = true)]
    public TestNdaResource NDA { get; set; }

    [DataMember(Name = ApiConsts.Members.ProgressBar, EmitDefaultValue = true)]
    public TestProgressBarResource ProgressBar { get; set; }

    [DataMember(Name = ApiConsts.Members.TestStyle, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TestStyle? TestStyle { get; set; }

    [DataMember(Name = ApiConsts.Members.StyleProfile, EmitDefaultValue = true)]
    public TestStyleProfileResource StyleProfile { get; set; }

    [DataMember(Name = ApiConsts.Members.DefaultNavigationLanguage, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TestDefaultNavigationLanguage? DefaultNavigationLanguage { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowLanguageOverride, EmitDefaultValue = true)]
    public bool? AllowLanguageOverride { get; set; }

    [DataMember(Name = ApiConsts.Members.ShowPageRequiresScrollingAlert, EmitDefaultValue = true)]
    public bool? ShowPageRequiresScrollingAlert { get; set; }

    [DataMember(Name = ApiConsts.Members.EasyPvalue, EmitDefaultValue = true)]
    public decimal? EasyPvalue { get; set; }

    [DataMember(Name = ApiConsts.Members.MaxEasyPvalue, EmitDefaultValue = true)]
    public decimal? MaxEasyPvalue { get; set; }

    [DataMember(Name = ApiConsts.Members.HardPvalue, EmitDefaultValue = true)]
    public decimal? HardPvalue { get; set; }

    [DataMember(Name = ApiConsts.Members.MinHardPvalue, EmitDefaultValue = true)]
    public decimal? MinHardPvalue { get; set; }

    [DataMember(Name = ApiConsts.Members.MinimumResitTime, EmitDefaultValue = true)]
    public int? MinimumResitTime { get; set; }

    [DataMember(Name = ApiConsts.Members.GenerateTestStatistics, EmitDefaultValue = true)]
    public bool? GenerateTestStatistics { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowPackagingOfCandidateResponses, EmitDefaultValue = true)]
    public bool? AllowPackagingOfCandidateResponses { get; set; }

    [DataMember(Name = ApiConsts.Members.AutomaticallyShowToCentre, EmitDefaultValue = true)]
    public bool? AutomaticallyShowToCentre { get; set; }

    [DataMember(Name = ApiConsts.Members.AutoCreatePIN, EmitDefaultValue = true)]
    public bool? AutoCreatePIN { get; set; }

    [DataMember(Name = ApiConsts.Members.StrictControlReasonableAdjustments, EmitDefaultValue = true)]
    public bool? StrictControlReasonableAdjustments { get; set; }

    [DataMember(Name = ApiConsts.Members.EnableCandidateLogging, EmitDefaultValue = true)]
    public bool? EnableCandidateLogging { get; set; }

    [DataMember(Name = ApiConsts.Members.ScoreBoundaries, EmitDefaultValue = true)]
    public TestScoreBoundariesResource ScoreBoundaries { get; set; }

    [DataMember(Name = ApiConsts.Members.UserAssociations, EmitDefaultValue = true)]
    public TestUserAssociationsResource UserAssociations { get; set; }
}