using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Candidate;
using SurpassApiSdk.DataContracts.Centre;
using SurpassApiSdk.DataContracts.Test;
using SurpassApiSdk.DataContracts.TestSchedule.Enum;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSchedule;

/// <summary>
/// Represents a test schedule details
/// </summary>
[DataContract(
    Name = "TestSchedule",
    Namespace = "http://schemas.datacontract.org/2004/07/Btl.Aspire.Administration.Web.Areas.Api.Version2.DataContracts.TestSchedule")]
public class TestScheduleResource
{
    /// <summary>
    /// Test for scheduling
    /// </summary>
    [DataMember(Order = 1)]
    public TestLinkedResource Test { get; set; }

    /// <summary>
    /// Centre for scheduling
    /// </summary>
    [DataMember(Order = 2)]
    public CentreResource Centre { get; set; }

    /// <summary>
    /// Candidate for scheduling
    /// </summary>
    [DataMember(Order = 3)]
    public QuickRegisterCandidateResource Candidate { get; set; }

    /// <summary>
    /// Type: string in format 'dd/mm/yyyy', less or equal to EndDateTime, mandatory.
    /// Time test will be available from.
    /// </summary>
    [DataMember(Name = ApiConsts.Members.StartDate, Order = 4)]
    public string StartDate { get; set; }

    /// <summary>
    /// Type: string in format 'dd/mm/yyyy', greater or equal to StartDateTime, mandatory.
    /// Time test will be available to.
    /// </summary>
    [DataMember(Name = ApiConsts.Members.EndDate, Order = 5)]
    public string EndDate { get; set; }

    /// <summary>
    /// Type: string in format 'dd/mm/yyyy', less or equal to EndDateTime, mandatory.
    /// Time test will be available from.
    /// </summary>
    [DataMember(Name = ApiConsts.Members.StartTime, Order = 6)]
    public string StartTime { get; set; }

    /// <summary>
    /// Type: string in format 'dd/mm/yyyy', less or equal to EndDateTime, mandatory.
    /// Time test will be available from.
    /// </summary>
    [DataMember(Name = ApiConsts.Members.EndTime, Order = 7)]
    public string EndTime { get; set; }

    [DataMember(Name = ApiConsts.Members.ReasonableAdjustments, Order = 8)]
    public ReasonableAdjustmentsResource ReasonableAdjustments { get; set; }

    [DataMember(Name = ApiConsts.Members.MarkedExternally, Order = 9)]
    public bool MarkedExternally { get; set; }

    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.AllowMultipleOpenSessions, Order = 10)]
    public bool AllowMultipleOpenSessions { get; set; }

    [DataMember(Name = ApiConsts.Members.RequiresInvigilation, Order = 11)]
    public bool? RequiresInvigilation { get; set; }

    [DataMember(Name = ApiConsts.Members.TestTags, Order = 12)]
    public TagNamedCollection<string> TestTags { get; set; }

    [DataMember(Order = 13)]
    public Resource TestForm { get; set; }

    [DataMember(Order = 14)]
    public Resource Marker { get; set; }

    [DataMember(Order = 15)]
    public Resource Moderator { get; set; }

    [DataMember(Name = ApiConsts.Members.PurchaseOrder, Order = 16)]
    public string PurchaseOrder { get; set; }

    [DataMember(Name = ApiConsts.Members.BreakReasonableAdjustments, Order = 17)]
    public BreakReasonableAdjustmentsResource BreakReasonableAdjustments { get; set; }

    [DataMember(Order = 18)]
    public Resource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.Language, EmitDefaultValue = true, Order = 19)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public SupportedExamLanguageCode? Language { get; set; }

    [DataMember(Name = ApiConsts.Members.EnforceTimes, Order = 20)]
    public bool? EnforceTimes { get; set; }

    [DataMember(Name = ApiConsts.Members.UnscheduledBreak, Order = 18)]

    public UnscheduledBreakResource UnscheduledBreak { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the test is scheduled as an OMR test
    /// </summary>
    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.UploadResponses, Order = 21, EmitDefaultValue = true, IsRequired = false)]
    public bool UploadResponses { get; set; }

    /// <summary>
    /// Gets or sets the external reference. This value is assigned to the scheduled exam session
    /// </summary>
    [DefaultValue(null)]
    [DataMember(
        Name = ApiConsts.Members.ExternalReference,
        Order = 22,
        EmitDefaultValue = true,
        IsRequired = false)]
    [MaxLength(30)]
    public string ExternalReference { get; set; }

    /// <summary>
    /// Gets or sets the Quality Review.
    /// </summary>
    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.QualityReview, Order = 23, IsRequired = false)]
    public bool QualityReview { get; set; }

    [DataMember(Name = ApiConsts.Members.UnlockOverride, Order = 24, IsRequired = false)]
    public UnlockOverrideResource UnlockOverride { get; set; }

    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.ForceRequireExamVersionDate, Order = 25, IsRequired = false)]
    public bool? ForceRequireExamVersionDate { get; set; }

    [DefaultValue(null)]
    public List<SelectedSectionsResource> SelectedSections { get; set; }

    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.RequiresCheckIn, Order = 27, IsRequired = false)]
    public bool RequiresCheckIn { get; set; }

    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.IsWholeScriptMarkingOn, Order = 28, IsRequired = false)]
    public bool IsWholeScriptMarkingOn { get; set; }
}