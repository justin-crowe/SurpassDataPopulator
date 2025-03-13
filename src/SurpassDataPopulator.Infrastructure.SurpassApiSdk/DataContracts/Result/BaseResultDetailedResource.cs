using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Result;

[DataContract(Name = ApiConsts.Contracts.Resource, Namespace = "")]
public abstract class BaseResultDetailedResource : BaseResultResource
{
    [DataMember(Name = ApiConsts.Members.Test)]
    public NameReferenceIdLinkedResource Test { get; set; }

    [DataMember(Name = ApiConsts.Members.TestForm)]
    public NameReferenceIdLinkedResource TestForm { get; set; }

    [DataMember(Name = ApiConsts.Members.Subject)]
    public NameReferenceIdLinkedResource Subject { get; set; }

    [DataMember(Name = ApiConsts.Members.ExternalReference)]
    public string ExternalReference { get; set; }

    [DataMember(Name = ApiConsts.Members.PassMark)]
    public double? PassMark { get; set; }

    [DataMember(Name = ApiConsts.Members.PassMarkType)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ResultMarkTypeKey? PassMarkType { get; set; }

    [DataMember(Name = ApiConsts.Members.PercentageMark)]
    public double? PercentageMark { get; set; }

    [DataMember(Name = ApiConsts.Members.PassPercentage)]
    public double? PassPercentage { get; set; }

    [DataMember(Name = ApiConsts.Members.IrtTheta)]
    public double? IrtTheta { get; set; }

    [DataMember(Name = ApiConsts.Members.PassIrt)]
    public double? PassIrt { get; set; }

    [DataMember(Name = ApiConsts.Members.Keycode)]
    public string Keycode { get; set; }

    [DataMember(Name = ApiConsts.Members.ResultsReleased)]
    public bool ResultReleased { get; set; }

    [DataMember(Name = ApiConsts.Members.ResultsSampled)]
    public bool ResultSampled { get; set; }

    [DataMember(Name = ApiConsts.Members.ScaleScore)]
    public double? ScaleScore { get; set; }

    [DataMember(Name = ApiConsts.Members.Pass)]
    public virtual bool Pass { get; set; }

    [DataMember(Name = ApiConsts.Members.CustomRoundingDecimalPlace, EmitDefaultValue = false)]
    public int? CustomRoundingDecimalPlace { get; set; }

    [DataMember(Name = ApiConsts.Members.DurationMode)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public DurationMode DurationMode { get; set; }

    [DataMember(Name = ApiConsts.Members.IsManuallySubmittedInLocal)]
    public bool IsManuallySubmittedInLocal { get; set; }

    [DataMember(Name = ApiConsts.Members.Sections)]
    public IEnumerable<SectionResource> Sections { get; set; }

    [DataMember(Name = ApiConsts.Members.LearningOutcomeThreshold, Order = 1000)]
    public int LearningOutcomesBoundariesThreshold { get; set; }

    [DataMember(Name = ApiConsts.Members.LearningOutcomeBoundariesApplied, Order = 1001)]
    public bool LearningOutcomeBoundariesApplied { get; set; }

    [DataMember(Name = ApiConsts.Members.LearningOutcomes, Order = 1002)]
    public List<LearningOutcomeResource> LearningOutcomes { get; set; }

    [DataMember(Name = ApiConsts.Members.LearningOutcomeBoundaries, Order = 1003)]
    public List<LearningOutcomeBoundaryResource> LearningOutcomeBoundaries { get; set; }

    [DataMember(Name = ApiConsts.Members.SectionSelectors, Order = 1004)]
    public IEnumerable<SectionSelectorResource> SectionSelectors { get; set; }

    [DataMember(Name = ApiConsts.Members.IrtDomain, Order = 1005)]
    public IEnumerable<IrtDomainGroupResource> IrtDomain { get; set; }

    [DataMember(Name = ApiConsts.Members.ExamWindowStartTime, Order = 1006)]
    public DateTime? ExamWindowStartTime { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowedDuration, Order = 1007)]
    public int AllowedDuration { get; set; }

    [DataMember(Name = ApiConsts.Members.ReasonableAdjustments, Order = 1008)]
    public ResultReasonableAdjustmentsResource ReasonableAdjustment { get; set; }

    [DataMember(Name = ApiConsts.Members.Remark, Order = 1009)]
    public string Remark { get; set; }

    [DataMember(Name = ApiConsts.Members.VoidReason, Order = 1009)]
    public string VoidReason { get; set; }

    [DataMember(Name = ApiConsts.Members.ActualDuration, Order = 1010)]
    public int? ActualDuration { get; set; }

    [DataMember(Name = ApiConsts.Members.CutScoreAvailableMarks, Order = 1011)]
    public int CutScoreAvailableMarks { get; set; }

    [DataMember(Name = ApiConsts.Members.PurchaseOrder, Order = 1012)]
    public string PurchaseOrder { get; set; }

    [DataMember(Name = ApiConsts.Members.Started, Order = 1013)]
    public bool Started { get; set; }

    [DataMember(Name = ApiConsts.Members.IsReview, Order = 1014)]
    public bool IsReview { get; set; }
}